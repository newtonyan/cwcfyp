using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject[] enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;
    public GameObject newparent;
    int randEnemy;
    // Use this for initialization
    void Start () {
        
        StartCoroutine(waitSpawner());
        

    }
	
	// Update is called once per frame
	void Update () {
        
        spawnWait = Random.Range(spawnLeastWait, spawnMostWait);
		
	}
    IEnumerator waitSpawner()
    {
        yield return new WaitForSeconds(startWait);

        while (!stop)
        {
            randEnemy = Random.Range(0,2);
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(1, 5), Random.Range(-spawnValues.z, spawnValues.z));
            if ((spawnPosition.x >= -14 && spawnPosition.x <= 14) && (spawnPosition.z <= 14 && spawnPosition.z >= -14))
            {
                yield return new WaitForSeconds(spawnWait);
            }
            else
            {
                var newenemy=Instantiate(enemies[randEnemy], spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                enemies[randEnemy].SetActive(true);
                newenemy.transform.parent = newparent.transform;
                yield return new WaitForSeconds(spawnWait);
            }
        }
    }
}
