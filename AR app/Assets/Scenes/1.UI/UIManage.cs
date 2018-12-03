using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Mapbox.Utils;
using TMPro;

public class UIManage : MonoBehaviour
{

    [SerializeField] private Text credittext;
    [SerializeField] private Text leveltext;

    [SerializeField] private GameObject mission;
    [SerializeField] private GameObject achievement;
    [SerializeField] private GameObject setting;
    [SerializeField] private GameObject gamestation;

    [SerializeField] private GameObject story;

    [SerializeField] private GameObject SettingButton;
    [SerializeField] private GameObject AchievementButton;
    [SerializeField] private GameObject MissionButton;
    [SerializeField] private GameObject ProfileBadge;
    [SerializeField] private Canvas MainCanvas;
    [SerializeField] private GameObject Map;

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
        Assert.IsNotNull(ProfileBadge);
        
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
    }

    public void toggleSetting()
    {
        ButtonClicked();
        setting.SetActive(!setting.activeSelf);
    }


    public void ButtonClicked()
    {
        audioSource.PlayOneShot(buttonSound);
    }


    private void Update()
    {
        updateLevel();
        updateCredit();
    }

    private int currentGSID = 0;

    public void toggleGameStation(int ID)
    {
        ButtonClicked();
        gamestation.SetActive(!gamestation.activeSelf);
        currentGSID = ID;
        //Debug.Log(currentGSID);
    }

    private void toggleGame()
    {
        List<GameObject> move = new List<GameObject>();
        move.Add(CUHKGameManager.Instance.CurrentPlayer.gameObject);
        SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_GAME2, move);
    }

    private void toggleStory()
    {
        ButtonClicked();
        Story content = story.GetComponent<Story>();
        content.setText(currentGSID); 
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

        MapZoneText.text = zone_name_ch;
    }

    public void Start()
    {
        DontDestroyOnLoad(this);
    }

}
