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
            Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), 1, Random.Range(-spawnValues.z, spawnValues.z));
            if ((spawnPosition.x >= 7 || spawnPosition.x <= -13) && (spawnPosition.z <= -29 || spawnPosition.z >= -7))
            {
                Instantiate(enemies[randEnermy], spawnPosition, gameObject.transform.rotation);
            }
            yield return new WaitForSeconds(spawnWait);
        }
    }
}
