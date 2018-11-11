using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class startandpausegame : MonoBehaviour {

    public int initTrackStatus = 0;
    public int PreTrackStatus = 0;
    public Button restartButton;
    public moverandomly male1;
    public moverandomly male2;
    public moverandomly male3;
    public moverandomly male4;
    public moverandomly male5;
    public moverandomly male6;
    public moverandomly male7;
    public moverandomly male8;
    public moverandomly male9;
    public moverandomly male10;
    public moverandomly male11;

    void Start() {
        Debug.Log("Not Yet Started");
        Time.timeScale = 0;
        male1.enabled = false;

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

    public void startgame()
    {
        Time.timeScale = 1;
        restartButton.enabled = false;
        male1.enabled = true;
    }

    
}
