using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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
       /*if (CheckPoint.CallFunction == true && !setting.activeInHierarchy && !achievement.activeInHierarchy && !mission.activeInHierarchy)
            if (!setting.activeInHierarchy && !achievement.activeInHierarchy && ! mission.activeInHierarchy)
            {
                Debug.Log("CWC");
                pregame.SetActive(!pregame.activeSelf);
                SettingButton.SetActive(!SettingButton.activeSelf);
                AchievementButton.SetActive(!AchievementButton.activeSelf);
                MissionButton.SetActive(!MissionButton.activeSelf);
                ProfileBadge.SetActive(!ProfileBadge.activeSelf);
                Map.SetActive(!Map.activeSelf);
                //PregameButton.SetActive(!PregameButton.activeSelf);
                CheckPoint.CallFunction = false;
            
            }*/
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

    
}
