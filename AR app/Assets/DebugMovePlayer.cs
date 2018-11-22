using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugMovePlayer : MonoBehaviour {
    public GameObject player;
    private Vector3 forward,right;

	// Use this for initialization
	void Start () {
        forward = new Vector3(0, 0, 0.1f);
        right = new Vector3(0.1f, 0, 0);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        if (Input.GetKey("w"))
        {
            player.transform.position = player.transform.position + forward;
        }

        if (Input.GetKey("a"))
        {
            player.transform.position = player.transform.position - right;
        }

        if (Input.GetKey("s"))
        {
            player.transform.position = player.transform.position - forward;
        }

        if (Input.GetKey("d"))
        {
            player.transform.position = player.transform.position + right;
        }

    }
}
