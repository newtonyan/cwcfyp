using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CUHKSceneManager : MonoBehaviour {

    public abstract void playerTapped(GameObject player);
    public abstract void collectableTapped(GameObject collectable);
    public abstract void buildingTapped(GameObject building);
    public abstract void checkpointTapped(GameObject checkpoint);


}
