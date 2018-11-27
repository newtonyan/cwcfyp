using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemies;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnMostWait;
    public float spawnLeastWait;
    public int startWait;
    public bool stop;

    int randEnermy;
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
            randEnermy = 0;
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), Random.Range(1, 5), Random.Range(-spawnValues.z, spawnValues.z));
            if ((spawnPosition.x >= -12 && spawnPosition.x <= 12) && (spawnPosition.z <= 12 && spawnPosition.z >= -12))
            {
                yield return new WaitForSeconds(spawnWait);
            }
            else
            {
                Instantiate(enemies, spawnPosition + transform.TransformPoint(0, 0, 0), gameObject.transform.rotation);
                enemies.SetActive(true);
                yield return new WaitForSeconds(spawnWait);
            }
        }
    }
}
