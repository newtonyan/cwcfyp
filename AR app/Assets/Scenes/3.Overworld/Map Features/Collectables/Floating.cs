using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floating : MonoBehaviour {
    [SerializeField] private float floatAmp = 2.0f;
    [SerializeField] private float floatFreq = 0.5f;

    private Vector3 startPos;

    private void Start()
    {
        startPos = transform.position;
    }

    void Update () {
        Vector3 tempPos = startPos + Vector3.up * 5;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * floatFreq) * floatAmp + 1;
        transform.position = tempPos;
	}
}