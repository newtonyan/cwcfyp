using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostchangeposition : MonoBehaviour
{
    public GameObject[] ghosts;
    void OnCollisionEnter(Collision col)
 {
        if (col.gameObject.tag == "Bullet")
        {

            gameObject.SetActive(false);
        }
    }
    

}
