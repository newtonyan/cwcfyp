using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Game1UIManager : MonoBehaviour
{

    [SerializeField] private GameObject pauseBtn;

    [SerializeField] private GameObject pauseMenu;
    [SerializeField] private GameObject resumeBtn;
    [SerializeField] private GameObject restartBtn;
    [SerializeField] private GameObject exitBtn;
    [SerializeField] private GameObject scanFrame;
    [SerializeField] private GameObject startMenu;

    [SerializeField] private TextMeshProUGUI pauseMsg;

    [SerializeField] private TextMeshProUGUI timeText;
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private AudioClip lostlifeSound;

    private AudioSource audioSource;
    private int initTrackStatus = 0;
    private int PreTrackStatus = 0;
    public GameObject PauseBtn
    {
        get { return pauseBtn; }
    }

    public GameObject ScanFrame
    {
        get { return scanFrame; }
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

    public TextMeshProUGUI LifeText
    {
        get { return lifeText; }
    }


    public GameObject StartMenu
    {
        get { return startMenu; }
    }

    private bool gamestarted = false;

    public void StartButtonPressed()
    {
        gamestarted = true;
        toggleStartMenu();
    }

    public void PauseButtonPressed()
    {
        Pause();
        pauseMsg.SetText("Paused");
        togglePauseMenu();
        toggleResumeButton();
        toggleExitButton();
        pauseBtn.GetComponent<Button>().enabled = false;
    }

    public void Win()
    {
        pauseMsg.SetText("You Win !");
        CUHKGameManager.Instance.CurrentPlayer.AddCredit(3);
        if (!CUHKGameManager.Instance.CurrentPlayer.collectableExist(10))
        {
            CUHKGameManager.Instance.CurrentPlayer.AddCollectables(10);
        }
        togglePauseMenu();
        toggleRestartButton();
        toggleExitButton();
        pauseBtn.GetComponent<Button>().enabled = false;
        Time.timeScale = 0f;
    }

    public void Lose()
    {
        pauseMsg.SetText("You Lose !");
        togglePauseMenu();
        toggleRestartButton();
        toggleExitButton();
        pauseBtn.GetComponent<Button>().enabled = false;
        Time.timeScale = 0f;
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
        Time.timeScale = 1;
        pauseBtn.GetComponent<Button>().enabled = true;
    }

    public void RestartButtonPressed()
    {
        SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_GAME1, new List<GameObject>());
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

    public void toggleScanFrame()
    {
        scanFrame.SetActive(!scanFrame.activeSelf);
    }

    public void setlifeText()
    {
        lifeText.text = "Life :" + PlayerPrefs.GetInt("Life");
    }

    public void setTimeText()
    {
        timeText.text = "Time : " + time;
    }

    [SerializeField] private int time;
    private int objectPlacedCount = 0;

    public void Update()
    {
        setlifeText();

        initTrackStatus = DefaultTrackableEventHandler.Tracking;

        if (gamestarted)
        {
            if(initTrackStatus == 1 && initTrackStatus != PreTrackStatus)
            {
                toggleScanFrame();
                PauseButtonPressed();
            }
            else if (initTrackStatus == 0 && initTrackStatus != PreTrackStatus)
            {
                if (pauseMenu.activeSelf)
                {
                    PauseButtonPressed();
                }
                toggleScanFrame();
                Time.timeScale = 0;
            }
        }
        else
        {
            if (initTrackStatus == 1 && initTrackStatus != PreTrackStatus)
            {
                toggleScanFrame();
                toggleStartMenu();
            }
            else if (initTrackStatus == 0 && initTrackStatus != PreTrackStatus)
            {
                toggleScanFrame();
                toggleStartMenu();
            }
        }
        /*if (!gamestarted && initTrackStatus == 1)
       {
           toggleScanFrame();
           toggleStartMenu();
           gamestarted = true;
       }

       if (gamestarted && initTrackStatus != PreTrackStatus && initTrackStatus == 0)
       {
           if (time == 60)
           {
               gamestarted = false;
               toggleScanFrame();
               toggleStartMenu();
           }
           /*else
           {
               Time.timeScale = 0;
               toggleScanFrame();
           }*/
        PreTrackStatus = initTrackStatus;
    }

    public void Start()
    {
        Time.timeScale = 0f;
        PlayerPrefs.SetInt("Life", 5);
        setTimeText();
        audioSource = GetComponent<AudioSource>();
    }

    public void GameStart()
    {
        Time.timeScale = 1f;
            StartCoroutine(Counter());
    }

    IEnumerator Counter()
    {
        while (time > 0 && PlayerPrefs.GetInt("Life")>0)
        {
            yield return new WaitForSeconds(1);
            time--;
            setTimeText();
            

        }
        if (PlayerPrefs.GetInt("Life") <= 0)
        {
            Lose();
        }
        else {
            Win();     
        }
    }

    public void lostlife()
    {
        audioSource.PlayOneShot(lostlifeSound);
    }

    public void restartgameafterlosetrack()
    {
       
}


}
