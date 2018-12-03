using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CUHKGameManager : singleton<CUHKGameManager> {
    private Player currentPlayer;
    [SerializeField] private UIManage gui;

    public UIManage GUI
    {
        get
        {
            return gui;
        }
        
    }

    public Player CurrentPlayer
    {
        get {
            if (currentPlayer == null)
            {
                currentPlayer = gameObject.AddComponent<Player>();
            }
            return currentPlayer;
        }
    }



}
