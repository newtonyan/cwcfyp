using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStation : MonoBehaviour {
    [SerializeField] private int stationID;
    /* Station ID List:
     * 10 - Gate of Wisdom
     * 9 - Woosing
     * 13 - NA
     * 11 - Lake */

    private bool panelsOn;


    public int StationID {
        get { return stationID; }
    }

    private void OnMouseDown()
    {
        CUHKGameManager.Instance.GUI.GetComponent<UIManage>().toggleGameStation(this.StationID);
        //GameObject GUI = GameObject.FindGameObjectWithTag("");
    }


    void Update()
    {
        if (CUHKGameManager.Instance.panelsOn)
        {
            BoxCollider bc = GetComponent<BoxCollider>();
            bc.enabled = false;
        }
        else
        {
            BoxCollider bc = GetComponent<BoxCollider>();
            bc.enabled = true;
        }
    }
}
