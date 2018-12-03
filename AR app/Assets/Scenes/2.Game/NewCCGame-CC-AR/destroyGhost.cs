using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyGhost : MonoBehaviour {

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Bullet")
        {
            gameObject.SetActive(false);
        }
    }
}
