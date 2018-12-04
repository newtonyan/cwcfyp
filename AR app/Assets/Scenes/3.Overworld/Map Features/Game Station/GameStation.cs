using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStation : MonoBehaviour {
    [SerializeField] private int stationID;
    /* Station ID List:
     * 1 - Gate of Wisdom
     * 2 - Woosing
     * 3 - NA
     * 4 - Lake */

    public int StationID {
        get { return stationID; }
    }

    private void OnMouseDown()
    {
        CUHKGameManager.Instance.GUI.GetComponent<UIManage>().toggleGameStation(this.StationID);
        //GameObject GUI = GameObject.FindGameObjectWithTag("");
    }
}
