using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ghostchangeposition : MonoBehaviour
{
    public GameObject[] ghosts;
    public void Start()
    {
            /*foreach (GameObject ghost in ghosts)
        {
            ghost.SetActive(false);
        }*/
    }
    /*public void Update()
    {
        GameObject[] allObjects = FindObjectsOfType<GameObject>();
        foreach (GameObject go in allObjects)
        {
            if (go.transform.position.x>=50 || go.transform.position.x <= -50 || go.transform.position.y >= 50 || go.transform.position.y <= -50 || 
                go.transform.position.z >= 50 || go.transform.position.z <= -50)
            {
                Destroy(go);
            }
        }
    }*/
    void OnCollisionEnter(Collision col)
 {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Ghost")
        {
            Destroy(gameObject);
            SpawnAnotherGhost();
        }
        }
    void SpawnAnotherGhost()
    {
        int i = Random.Range(0, ghosts.Length);
        ghosts[i].SetActive(true);

    }

}
