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
    [SerializeField] private GameObject pregame;
    [SerializeField] private GameObject story;
    [SerializeField] private GameObject SettingButton;
    [SerializeField] private GameObject AchievementButton;
    [SerializeField] private GameObject MissionButton;
    [SerializeField] private GameObject ProfileBadge;
    [SerializeField] private GameObject PregameButton;


    private void Awake()
    {
        Assert.IsNotNull(credittext);
        Assert.IsNotNull(leveltext);
        Assert.IsNotNull(mission);
        Assert.IsNotNull(achievement);
        Assert.IsNotNull(setting);
        Assert.IsNotNull(pregame);
        Assert.IsNotNull(story);
        Assert.IsNotNull(SettingButton);
        Assert.IsNotNull(AchievementButton);
        Assert.IsNotNull(MissionButton);
        Assert.IsNotNull(ProfileBadge);
        Assert.IsNotNull(PregameButton);


        // ensure all variables sets and not run into any null areas
    }

    public void updateLevel(int level)
    {
        leveltext.text = level.ToString();
    }

    public void updatecredit(int currentcredit, int requiredcredit)
    {
        credittext.text = currentcredit.ToString() + "/" + requiredcredit.ToString();
    }

    public void toggleMission()
    {
        mission.SetActive(!mission.activeSelf);
    }

    public void toggleAchievement()
    {
        achievement.SetActive(!achievement.activeSelf);
    }

    public void toggleSetting()
    {
        setting.SetActive(!setting.activeSelf);
    }


    public void toggleStory()
    {
        story.SetActive(!story.activeSelf);
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //Select Stage
            if (hit.transform.name == "PregameButton" && Input.GetMouseButtonDown(0)&& !setting.activeInHierarchy && !achievement.activeInHierarchy && ! mission.activeInHierarchy)
            {
                Debug.Log("diu");
                pregame.SetActive(!pregame.activeSelf);
                SettingButton.SetActive(!SettingButton.activeSelf);
                AchievementButton.SetActive(!AchievementButton.activeSelf);
                MissionButton.SetActive(!MissionButton.activeSelf);
                ProfileBadge.SetActive(!ProfileBadge.activeSelf);
                PregameButton.SetActive(!PregameButton.activeSelf);
            }
        }
    }

    public void togglePregame()
    {
        pregame.SetActive(!pregame.activeSelf);
        SettingButton.SetActive(!SettingButton.activeSelf);
        AchievementButton.SetActive(!AchievementButton.activeSelf);
        MissionButton.SetActive(!MissionButton.activeSelf);
        ProfileBadge.SetActive(!ProfileBadge.activeSelf);
        PregameButton.SetActive(!PregameButton.activeSelf);
    }

    public void toggleNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
