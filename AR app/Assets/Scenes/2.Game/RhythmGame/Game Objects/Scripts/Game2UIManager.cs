using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Game2UIManager : MonoBehaviour {

    [SerializeField] private GameObject pauseBtn;
    [SerializeField] private GameObject stompBtn;
    [SerializeField] private GameObject clapBtn;

    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject resumeBtn;
    [SerializeField] private GameObject restartBtn;
    [SerializeField] private GameObject exitBtn;

    [SerializeField] private GameObject startMenu;
    [SerializeField] private GameObject planeFinder;

    [SerializeField] private TextMeshProUGUI pauseMsg;

    [SerializeField] private TextMeshProUGUI multiplierText;
    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI streakText;


    public GameObject PauseBtn
    {
        get { return pauseBtn; }
    }

    public GameObject StompBtn
    {
        get { return stompBtn; }
    }

    public GameObject ClapBtn
    {
        get { return clapBtn; }
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

    public TextMeshProUGUI MultiplierText
    {
        get { return multiplierText; }
    }

    public TextMeshProUGUI ScoreText
    {
        get { return scoreText; }
    } 

    public TextMeshProUGUI StreakText
    {
        get { return streakText; }
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
        clapBtn.GetComponent<Button>().enabled = false;
        stompBtn.GetComponent<Button>().enabled = false;
        PauseAudio();
    }

    public void Win()
    {
        pauseMsg.SetText("You Win !");
        togglePauseMenu();
        toggleRestartButton();
        toggleExitButton();
        pauseBtn.GetComponent<Button>().enabled = false;
        clapBtn.GetComponent<Button>().enabled = false;
        stompBtn.GetComponent<Button>().enabled = false;
        CUHKGameManager.Instance.CurrentPlayer.AddCredit(3);
        if (!CUHKGameManager.Instance.CurrentPlayer.collectableExist(9))
        {
            CUHKGameManager.Instance.CurrentPlayer.AddCollectables(9);
        }
    }

    public void Lose()
    {
        pauseMsg.SetText("You Lose !");
        togglePauseMenu();
        toggleRestartButton();
        toggleExitButton();
        pauseBtn.GetComponent<Button>().enabled = false;
        clapBtn.GetComponent<Button>().enabled = false;
        stompBtn.GetComponent<Button>().enabled = false;
    }

    private void Pause()
    {
        Time.timeScale = 0f;
    }

    private void Resume()
    {
        Time.timeScale = 1f;
    }

    public void ResumeButtonPressed()
    {
        Resume();
        ResumeAudio();
        togglePauseMenu();
        toggleResumeButton();
        toggleExitButton();
        pauseBtn.GetComponent<Button>().enabled = true;
        clapBtn.GetComponent<Button>().enabled = true;
        stompBtn.GetComponent<Button>().enabled = true;
    }

    public void RestartButtonPressed()
    {
        SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_GAME2, new List<GameObject>());
    }

    public void ExitButtonPressed()
    {
        SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_WORLD, new List<GameObject>());
        Time.timeScale = 1f;
    }

    public void toggleStartMenu()
    {
            startMenu.SetActive(!startMenu.activeSelf);
            planeFinder.SetActive(false);
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

    public void setMultiplierText()
    {
        multiplierText.text = "Bonus : " +PlayerPrefs.GetInt("Multiplier") + "" +"X";
    }

    public void setStreakText()
    {
        streakText.text = "Streak : " + PlayerPrefs.GetInt("Streak") + "";
    }

    public void PauseAudio()
    {
        AudioListener.pause = true;
    }


    public void ResumeAudio()
    {
        AudioListener.pause = false;
    }

    public void Update()
    {
        setScoreText();
        setMultiplierText();
        setStreakText();
    }

    public void Start()
    {
        Time.timeScale = 1f;
        ResumeAudio();
    }

}
