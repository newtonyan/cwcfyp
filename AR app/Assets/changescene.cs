using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
public class changescene : UnityEngine.MonoBehaviour
{

    // Use this for initialization
    void OnMouseDrag()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);


    }
}
