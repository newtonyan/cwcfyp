using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
    private void Update()
    {

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit))
        {
            //Select Stage
            if (hit.transform.name == "Tree of Wisdom " && Input.GetMouseButtonDown(0))
            {
                Debug.Log("CWC");
            }

        }
    }
}
