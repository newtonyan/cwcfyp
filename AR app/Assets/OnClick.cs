using System.Collections;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnClick : MonoBehaviour {

    [SerializeField] private GameObject pregame;
    [SerializeField] private GameObject SettingButton;
    [SerializeField] private GameObject AchievementButton;
    [SerializeField] private GameObject MissionButton;
    [SerializeField] private GameObject ProfileBadge;
    [SerializeField] private GameObject PregameButton;

    private void Awake()
    {
        Assert.IsNotNull(pregame);
        Assert.IsNotNull(SettingButton);
        Assert.IsNotNull(AchievementButton);
        Assert.IsNotNull(MissionButton);
        Assert.IsNotNull(ProfileBadge);
        Assert.IsNotNull(PregameButton);

        // ensure all variables sets and not run into any null areas
    }

    void Update () 
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //Select Stage
            if (hit.transform.name == "PregameButton" && Input.GetMouseButtonDown(0))
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
