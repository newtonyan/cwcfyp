using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CUHKGameManager : singleton<CUHKGameManager> {
    [SerializeField] private Player currentPlayer;
    [SerializeField] private UIManage gui;

    public UIManage GUI
    {
        get { return gui; }
    }

    public Player CurrentPlayer
    {
        get { return currentPlayer; }
    }

    private void Awake()
    {
        Assert.IsNotNull(currentPlayer);
    }

}
