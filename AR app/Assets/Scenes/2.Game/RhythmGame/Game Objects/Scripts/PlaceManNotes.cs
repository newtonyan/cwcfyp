using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceManNotes : MonoBehaviour {

    Rigidbody2D rb;
    [SerializeField] private float speed;

    private void Awake()
    {
        rb = GetComponent <Rigidbody2D>();
        rb.velocity = new Vector2(0, 0);
    }

    public void EnableNotes () {
        StartCoroutine(StartGameWait());  
    }


    IEnumerator StartGameWait()
    {
        Debug.Log(Time.time);
        yield return new WaitForSecondsRealtime(1);
        Debug.Log(Time.time);
        rb.velocity = new Vector2(-speed, 0);
        Debug.Log(rb.velocity);
    }


}
