using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startandpausegame : MonoBehaviour {

    bool isPaused = true;
    public int initTrackStatus = 0;
    public int PreTrackStatus = 0;
    public Button restartButton;

    void Start() {
        Debug.Log("Not Yet Started");
        Time.timeScale = 0;
        
    }
    private void Update()
    {
        initTrackStatus = DefaultTrackableEventHandler.Tracking;
        if(initTrackStatus!= PreTrackStatus && initTrackStatus == 1)
        {
            Debug.Log("Status Changed");
            restartButton.enabled = true;
        }
        else if(initTrackStatus != PreTrackStatus && initTrackStatus == 0)
        {
            Time.timeScale = 0;
        }
        PreTrackStatus = initTrackStatus;

    }

    public void pauseGame()
    {
        if (isPaused)
        {
            Time.timeScale = 1;
            isPaused = false;
        }
        else
        {
            Time.timeScale = 0;
            isPaused = true;
        }
    }

    
}
