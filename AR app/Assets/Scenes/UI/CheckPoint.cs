using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class CheckPoint : MonoBehaviour
{
    public static bool CallFunction = false;
    public UIManage UIcontrol;

    private void OnMouseDown()
    {

        CallFunction = true;
        Debug.Log("CWC");
        UIcontrol.togglePregame();
        

    }


}
