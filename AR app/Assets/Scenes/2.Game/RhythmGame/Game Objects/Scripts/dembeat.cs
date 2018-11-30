using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dembeat : MonoBehaviour {

    public Animator anim;
    public GameObject clap, stomp;
    public KeyCode key1, key2;

    void Start () {
        anim = GetComponent<Animator>();

	}

    void Update()
    {
        if(clap.GetComponent<ActivatorGame>().ButtonClicked || Input.GetKeyDown(key1))
        {
            Debug.Log("clap");
            anim.Play("clap");
       }

        if(stomp.GetComponent<ActivatorGame>().ButtonClicked || Input.GetKeyDown(key2))
        {
            Debug.Log("stomp");
            anim.Play("stomp");

        }
    }

}
