using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class PlayerData {
    private int credit;
    private List<int> collectables;

    public int Credit
    {
        get { return credit; }
    }

    public List<int> Collectables
    {
        get { return collectables; }
    }

    public PlayerData(Player player)
    {
        credit = player.Credit;
        collectables = player.Collectables;
    }

}
