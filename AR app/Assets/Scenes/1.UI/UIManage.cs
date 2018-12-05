using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mapbox.Utils;
using TMPro;
using Mapbox.Unity.Map;

public class UIManage : MonoBehaviour
{

    [SerializeField] private Text credittext;
    [SerializeField] private Text leveltext;

    [SerializeField] private GameObject mission;
    [SerializeField] private GameObject achievement;

    [SerializeField] private GameObject setting;
    [SerializeField] private GameObject chBtn;
    [SerializeField] private GameObject chBtnGrey;
    [SerializeField] private GameObject engBtn;
    [SerializeField] private GameObject engBtnGrey;

    [SerializeField] private GameObject gamestation;
    [SerializeField] private GameObject miniMap;

    [SerializeField] private GameObject story;

    [SerializeField] private GameObject SettingButton;
    [SerializeField] private GameObject AchievementButton;
    [SerializeField] private GameObject MissionButton;
    [SerializeField] private GameObject MapButton;
    [SerializeField] private GameObject Map;
    [SerializeField] private GameObject NotInCUHK;
    [SerializeField] private GameObject gameUnable;

    [SerializeField] private GameObject CurrentLocation;
    [SerializeField] private TextMeshProUGUI MapZoneText;

    [SerializeField] private AudioClip buttonSound;
    private AudioSource audioSource;

    public GameObject Story
    {
        get { return story; }
    }

    private void Awake()
     {
        audioSource = GetComponent<AudioSource>();

        Assert.IsNotNull(credittext);
        Assert.IsNotNull(leveltext);

        Assert.IsNotNull(mission);
        Assert.IsNotNull(achievement);
        Assert.IsNotNull(setting);
        Assert.IsNotNull(gamestation);
        Assert.IsNotNull(story);
        Assert.IsNotNull(SettingButton);
        Assert.IsNotNull(AchievementButton);
        Assert.IsNotNull(MissionButton);
        
        //audio
        Assert.IsNotNull(buttonSound);
        Assert.IsNotNull(audioSource);

     }

    public void updateLevel()
    {
        leveltext.text = CUHKGameManager.Instance.CurrentPlayer.Lvl.ToString();
    }

    public void updateCredit()
    {
        credittext.text = CUHKGameManager.Instance.CurrentPlayer.Credit.ToString() + "/" + CUHKGameManager.Instance.CurrentPlayer.RequiredCredit.ToString();
    }

    public void toggleMission()
    {
        ButtonClicked();
        mission.SetActive(!mission.activeSelf);
    }

    public void toggleAchievement()
    {
        ButtonClicked();
        achievement.SetActive(!achievement.activeSelf);
        GameObject[] inventory = GameObject.FindGameObjectsWithTag("Collectables");
        foreach (GameObject obj in inventory)
        {
            Debug.Log("Collectables");
            obj.GetComponent<inventory>().checkStatus();
        }
    }

    public void toggleSetting()
    {
        ButtonClicked();
        setting.SetActive(!setting.activeSelf);
    }

    public void toggleMiniMap()
    {
        ButtonClicked();
        miniMap.SetActive(!miniMap.activeSelf);
    }


    public void ButtonClicked()
    {
        audioSource.PlayOneShot(buttonSound);
    }

    public void toggleNotInCUHK()
    {
        NotInCUHK.SetActive(true);
    }

    public void toggleGameUnable()
    {
        gameUnable.SetActive(!gameUnable.activeSelf);
    }

    private GameObject[] panels;

    private void Update()
    {
        updateLevel();
        updateCredit();
       
        panels = GameObject.FindGameObjectsWithTag("UI Panels");
        if (panels.Length == 0)
        {
            Debug.Log("No active panels");
            CUHKGameManager.Instance.panelsOn = false;
        }
        else
        {
            Debug.Log("active panels");
            CUHKGameManager.Instance.panelsOn = true;
        }  
}

    private int currentGSID = 0;

    public void toggleGameStation()
    {
        ButtonClicked();
        gamestation.SetActive(!gamestation.activeSelf);
    }

    public void toggleGameStation(int ID)
    {
        ButtonClicked();
        gamestation.SetActive(!gamestation.activeSelf);
        currentGSID = ID;
        Debug.Log(currentGSID);
    }

    public void toggleGame()
    {
        //Debug.Log("toggleGame");
        if (currentGSID == 10)
        {
            SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_GAME1, new List<GameObject>());
            //Debug.Log("toggleGame1");
        }
        else if (currentGSID == 9)
        {
            SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_GAME2, new List<GameObject>());
            //Debug.Log("toggleGame2");
        }
        else if (currentGSID == 13)
        {
            SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_GAME3, new List<GameObject>());
            //Debug.Log("toggleGame3");
        }
        else if (currentGSID == 11)
        {
            //if(CUHKGameManager.Instance.CurrentPlayer.collectableExist(9) && CUHKGameManager.Instance.CurrentPlayer.collectableExist(10) && CUHKGameManager.Instance.CurrentPlayer.collectableExist(13))
            //{
                SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_GAME4, new List<GameObject>());
                //Debug.Log("toggleGame4");
            //}
            //else
            //{
             //   toggleGameUnable();
            //}
            
        }

    }

    public void toggleStory()
    {
        ButtonClicked();
        Story content = story.GetComponent<Story>();
        content.setText(currentGSID); 
        story.SetActive(!story.activeSelf);
    }

    public void toggleStory(int id)
    {
        ButtonClicked();
        Story content = story.GetComponent<Story>();
        content.setText(id);
        story.SetActive(!story.activeSelf);
    }

    public void toggleNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void getGPSlocation(Vector2d currentLocation)
    {
        MapZone zone = GetComponent<MapZone>();
        string zone_name, zone_name_ch;
        zone_name = zone.GetAreaName(currentLocation);
        zone_name_ch = zone.GetValueByKey(zone_name);
        Debug.Log(zone_name);

        if (CUHKGameManager.Instance.Language)
        {
            MapZoneText.text = zone_name_ch;
        }
        else
        {
            MapZoneText.text = zone_name;
        }
        if(zone_name== "not in CUHK")
        {
            toggleNotInCUHK();
        }
        else
        {
            NotInCUHK.SetActive(false);
        }
    }

    public void setChinese()
    {
        chBtn.SetActive(true);
        chBtnGrey.SetActive(false);
        engBtn.SetActive(false);
        engBtnGrey.SetActive(true);
        CUHKGameManager.Instance.Language = true;
        SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_WORLD, new List<GameObject>());
    }

    public void setEnglish()
    {
        engBtn.SetActive(true);
        engBtnGrey.SetActive(false);
        chBtn.SetActive(false);
        chBtnGrey.SetActive(true);
        CUHKGameManager.Instance.Language = false ;
        SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_WORLD, new List<GameObject>());
    }

    public void Start()
    {
        //DontDestroyOnLoad(this);
        if (CUHKGameManager.Instance.Language)
        {
            chBtn.SetActive(true);
            chBtnGrey.SetActive(false);
            engBtn.SetActive(false);
            engBtnGrey.SetActive(true);
        }
        else
        {
            engBtn.SetActive(true);
            engBtnGrey.SetActive(false);
            chBtn.SetActive(false);
            chBtnGrey.SetActive(true);
        }
    }

}
