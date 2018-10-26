using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class lifebar : MonoBehaviour {
    public GameObject PillarA;
    public GameObject PillarB;
    private int lastFrame = 0; // 0 if position < line, 1 if position >= line
    private int thisFrame = 0;
    private int isInitial = 1; 
    Vector3 pos, posB, posA;
    void Start()
    {
        pos = new Vector3(0, 0, 0);
        pos = transform.position;
        Debug.Log(pos);
        posA = new Vector3(0, 0, 0);
        posA = PillarA.transform.position;
        Debug.Log(posA);
        posB = new Vector3(0, 0, 0);
        posB = PillarB.transform.position;
        Debug.Log(posB);
    }
    // Update is called once per frame
    void Update() {
        pos = transform.position;
        if (isInitial == 1)
        {
            isInitial = 0;
            if (pos.z < posA.z)
            {
                lastFrame = 0;
            }
            else
            {
                lastFrame = 1;
            }
        }
        if (pos.z < posA.z)
        {
            thisFrame = 0;
            //Debug.Log("This Frame: " + thisFrame +" at" + pos.z);
        }
        else
        {
            thisFrame = 1;
            //Debug.Log("This Frame: " + thisFrame + " at" + pos.z);
        }

        //if (pos.z == posA.z && pos.x > posA.x && pos.x > posB.x)
        if(thisFrame != lastFrame && pos.x > posA.x && pos.x < posB.x)
        {
            //Debug.Log("Pass through " + "Last= " + lastFrame + "This= " + thisFrame);
            Globallifebar.health--;
        }
        lastFrame = thisFrame;
    }
        
    
}
