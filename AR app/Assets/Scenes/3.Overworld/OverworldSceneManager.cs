using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverworldSceneManager : CUHKSceneManager {

    [SerializeField] private int collectableBonus = 2;

    public override void buildingTapped(GameObject building)
    {
        
    }

    public override void checkpointTapped(GameObject checkpoint)
    {
        
    }
    
    public override void collectableTapped(GameObject collectable)
    {
        CUHKGameManager.Instance.CurrentPlayer.AddCredit(collectableBonus);
        CUHKGameManager.Instance.CurrentPlayer.AddCollectables(collectable);
    }

    public override void playerTapped(GameObject player)
    {
        
    }

}
