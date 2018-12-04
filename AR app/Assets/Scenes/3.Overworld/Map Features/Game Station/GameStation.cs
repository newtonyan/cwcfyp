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

    public int StationID {
        get { return stationID; }
    }

    private void OnMouseDown()
    {
        CUHKGameManager.Instance.GUI.GetComponent<UIManage>().toggleGameStation(this.StationID);
        //GameObject GUI = GameObject.FindGameObjectWithTag("");
    }
}
