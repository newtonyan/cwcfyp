using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class moverandomly : MonoBehaviour {

    NavMeshAgent navMeshAgent;
    NavMeshPath path;
    public float timeForNewPath;
    bool inCoRouitine;
    Vector3 target;
    bool validPath;
    Vector3 dist;
    float posX;
    float posY;

    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        path = new NavMeshPath();
    }
    void Update()
    {
        if (!inCoRouitine)
            StartCoroutine(Dosomething());
    }

    Vector3 getNewRandomPosition()
    {
        float x = Random.Range(-10, 10);
        float z = Random.Range(-10, 10);

        Vector3 pos = new Vector3(x, 0, z);
        return pos;
    }
    IEnumerator Dosomething()
    {
        inCoRouitine = true;
        yield return new WaitForSeconds(timeForNewPath);
        GetNewPath();
        validPath = navMeshAgent.CalculatePath(target, path);
        if (!validPath) Debug.Log("Found an invalid path");

        while (!validPath)
        {
            yield return new WaitForSeconds(0.0001f);
            GetNewPath();
            validPath = navMeshAgent.CalculatePath(target, path);
        }
        inCoRouitine = false;
    }
    void GetNewPath()
    {
        target = getNewRandomPosition();
        navMeshAgent.SetDestination(target);
    }
    void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }
    void OnMouseDrag()
    {
        Vector3 mousePosition = new Vector3(Input.mousePosition.x - posX, Input.mousePosition.y - posY, dist.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
    }
}
