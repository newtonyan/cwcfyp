using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Game4UIManager : MonoBehaviour
{

    [SerializeField] private GameObject pauseBtn;

    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject resumeBtn;
    [SerializeField] private GameObject restartBtn;
    [SerializeField] private GameObject exitBtn;

    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject planeFinder;

    [SerializeField] private TextMeshProUGUI pauseMsg;

    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI scoreText;

    [SerializeField] private GameObject shootBtn;

    [SerializeField] private AudioClip getHitSound;
    [SerializeField] private AudioClip shootSound;

    private AudioSource audioSource;

    public GameObject bulletprefab;

    public GameObject PauseBtn
    {
        get { return pauseBtn; }
    }


    public GameObject PauseMenu
    {
        get { return pauseMenu; }
    }

    public GameObject ResumeBtn
    {
        get { return resumeBtn; }
    }

    public GameObject ExitBtn
    {
        get { return exitBtn; }
    }

    public TextMeshProUGUI PauseMsg
    {
        get { return pauseMsg; }
    }

    public TextMeshProUGUI TimeText
    {
        get { return timeText; }
    }

    public TextMeshProUGUI ScoreText
    {
        get { return scoreText; }
    }


    public GameObject StartMenu
    {
        get { return startMenu; }
    }

    public void PauseButtonPressed()
    {
        Pause();
        pauseMsg.SetText("Paused");
        togglePauseMenu();
        toggleResumeButton();
        toggleExitButton();
        pauseBtn.GetComponent<Button>().enabled = false;
        shootBtn.GetComponent<Button>().enabled = false;
    }

    public void Win()
    {
        pauseMsg.SetText("You Win !");
        togglePauseMenu();
        toggleRestartButton();
        toggleExitButton();
        pauseBtn.GetComponent<Button>().enabled = false;
        shootBtn.GetComponent<Button>().enabled = false;
        CUHKGameManager.Instance.CurrentPlayer.AddCredit(3);
        if (!CUHKGameManager.Instance.CurrentPlayer.collectableExist(11))
        {
            CUHKGameManager.Instance.CurrentPlayer.AddCollectables(11);
        }
    }

    public void Lose()
    {
        pauseMsg.SetText("You Lose !");
        togglePauseMenu();
        toggleRestartButton();
        toggleExitButton();
        pauseBtn.GetComponent<Button>().enabled = false;
        shootBtn.GetComponent<Button>().enabled = false;
    }

    private void Pause()
    {
        Time.timeScale = 0f;
    }

    private void Resume()
    {
        StartCoroutine(delay());
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(1);
        Time.timeScale = 1f;
    }
    public void ResumeButtonPressed()
    {
        Resume();
        togglePauseMenu();
        toggleResumeButton();
        toggleExitButton();
        pauseBtn.GetComponent<Button>().enabled = true;
        shootBtn.GetComponent<Button>().enabled = true;
    }

    public void RestartButtonPressed()
    {
        SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_GAME4, new List<GameObject>());
    }

    public void ExitButtonPressed()
    {
        SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_WORLD, new List<GameObject>());
        Time.timeScale = 1f;
    }

    public void toggleStartMenu()
    {
        startMenu.SetActive(!startMenu.activeSelf);
    }

    public void togglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }

    public void toggleRestartButton()
    {
        restartBtn.SetActive(!restartBtn.activeSelf);
    }

    public void toggleResumeButton()
    {
        resumeBtn.SetActive(!resumeBtn.activeSelf);
    }

    public void toggleExitButton()
    {
        exitBtn.SetActive(!exitBtn.activeSelf);
    }

    public void setScoreText()
    {
        scoreText.text = PlayerPrefs.GetInt("Score") + "";
    }

    public void setTimeText()
    {
        timeText.text = "Time : " + time;
    }

    [SerializeField] private int time;
    [SerializeField] private int winScore;
    private int objectPlacedCount = 0;

    public void Update()
    {
        setScoreText();
    }

    public void Start()
    {
        PlayerPrefs.SetInt("Score", 0);
        setTimeText();
        audioSource = GetComponent<AudioSource>();
    }

    public void GameStart()
    {
        Time.timeScale = 1f;
        if (objectPlacedCount < 1)
        {
            StartCoroutine(Counter());
        }
        objectPlacedCount++;
    }

    IEnumerator Counter()
    {
        while (time>0)
        {
            if (PlayerPrefs.GetInt("Score") >= winScore)
            {
                Time.timeScale = 0f;
                Win();
                yield return 0;
            }
            yield return new WaitForSeconds(1);
            time--;
            setTimeText();

        }
        Lose();
    }

    public void shoot()
    {
        audioSource.PlayOneShot(shootSound);
    }

    public void getHit()
    {
        audioSource.PlayOneShot(getHitSound);
    }


}
