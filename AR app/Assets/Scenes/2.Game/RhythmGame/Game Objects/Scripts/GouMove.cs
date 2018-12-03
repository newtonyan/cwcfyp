using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GouMove : MonoBehaviour {

    public Animator anim;

    void Awake()
    {
        anim = GetComponent<Animator>();
        anim.speed = 0;
    }

    public void GouFing() {
        anim.speed = 1;
    }

}
