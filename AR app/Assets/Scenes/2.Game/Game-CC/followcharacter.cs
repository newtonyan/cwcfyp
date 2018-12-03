using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class followcharacter : MonoBehaviour
{
    public Transform target;
    NavMeshAgent agent;
    public float lookradius = 2f;
    public GameObject objecttodiable;
    void Start()
    {
        target = target.transform;
        agent = GetComponent<NavMeshAgent>();
        objecttodiable.GetComponent<MeshCollider>().enabled = true;
        objecttodiable.GetComponent<MeshRenderer>().enabled = true;
        objecttodiable.GetComponent<CapsuleCollider>().enabled = true;
    }
    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(target.position, transform.position);
        agent.SetDestination(target.position);
        Facetarget();
        if (distance<= lookradius && distance != 0)
        {
            GloballifebarCC.health--;
            Debug.Log(GloballifebarCC.health);
            objecttodiable.SetActive(false);
            transform.position = transform.TransformPoint(1000, 1000, 1000);
            objecttodiable.SetActive(true);
            objecttodiable.GetComponent<MeshCollider>().enabled = true;
            objecttodiable.GetComponent<MeshRenderer>().enabled = true;
            objecttodiable.GetComponent<CapsuleCollider>().enabled = true;
        }
    }
    void Facetarget()
    {
        Vector3 direction = (target.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 5f);
    }
}
