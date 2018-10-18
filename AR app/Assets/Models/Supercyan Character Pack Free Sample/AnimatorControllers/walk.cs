using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour {

    private Animator anim;
    private float vert;
	// Use this for initialization
	void Start () {

        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {

        anim.SetFloat("walk", vert);
		
	}
}
