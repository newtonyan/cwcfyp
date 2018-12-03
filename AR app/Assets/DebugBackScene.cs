using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DebugBackScene : MonoBehaviour {

    public void goBackScene()
    {
        SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_WORLD, new List<GameObject>());
    }

}
