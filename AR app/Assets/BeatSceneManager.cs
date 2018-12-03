using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatSceneManager : CUHKSceneManager {
    public override void playerTapped(GameObject player)
    {
    }

    public override void collectableTapped(GameObject collectable)
    {
    }

    public override void buildingTapped(GameObject building)
    {
    }

    public override void checkpointTapped(GameObject checkpoint)
    {
    }

    private void Start()
    {
        Debug.Log("Start Beat Scene. Player XP is : " + CUHKGameManager.Instance.CurrentPlayer.Credit);
        CUHKGameManager.Instance.CurrentPlayer.AddCredit(500);
        Debug.Log("Player XP is : " + CUHKGameManager.Instance.CurrentPlayer.Credit);
    }
}
