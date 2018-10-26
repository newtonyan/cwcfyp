using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Globallifebar : MonoBehaviour {
    public static int health = 5;
    public Sprite[] HeartSprites;
    public Image HeartUI;

	// Update is called once per frame
	void Update () {
        HeartUI.sprite = HeartSprites[health];
    }
}
