using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public GameObject bulletprefab;
    [SerializeField] GameObject GUI;
    

    private void Update()
    {
        /*if (Input.GetMouseButtonDown(0))
        {
            GameObject go = Instantiate(bulletprefab, transform.position, transform.rotation) as GameObject;
            go.GetComponent<Rigidbody>().AddForce(transform.forward * 8, ForceMode.Impulse);
        }*/
    }

    public void shoot()
    {
        GameObject go = Instantiate(bulletprefab, transform.position, transform.rotation) as GameObject;
        go.GetComponent<Rigidbody>().AddForce(transform.forward * 8, ForceMode.Impulse);
        GUI.GetComponent<Game4UIManager>().shoot();
    }
}
