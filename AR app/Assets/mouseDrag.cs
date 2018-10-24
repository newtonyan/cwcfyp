using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseDrag : MonoBehaviour {
    Vector3 dist;
    float posX;
    float posY;

    void OnMouseDown()
    {
        dist = Camera.main.WorldToScreenPoint(transform.position);
        posX = Input.mousePosition.x - dist.x;
        posY = Input.mousePosition.y - dist.y;
    }
    void OnMouseDrag()
    {
        GetComponent<moverandomly>().enabled = false;
        Vector3 mousePosition = new Vector3(Input.mousePosition.x-posX, Input.mousePosition.y-posY, dist.z);
        Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        transform.position = objPosition;
    }
}
