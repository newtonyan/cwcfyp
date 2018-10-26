using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boycontroller : MonoBehaviour {

    static Animator anim;
    public float speed = 2.0f;
    public float rotationSpeed = 75.0f;
    public Transform[] target;

    private int current;

    // Use this for initialization
    void Start () {

        anim = GetComponent<Animator>();
		
	}
	
	// Update is called once per frame
	void Update () {
        if (transform.position != target[current].position)
        {
            Vector3 direction = target[current].position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotationSpeed * Time.deltaTime);
            Vector3 pos = Vector3.MoveTowards(transform.position, target[current].position, speed * Time.deltaTime);
            GetComponent<Rigidbody>().MovePosition(pos);
        }
        else current = (current + 1) % target.Length;
    }
}
