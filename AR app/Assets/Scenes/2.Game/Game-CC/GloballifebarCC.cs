using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GloballifebarCC : MonoBehaviour {

    public static int health = 5;
    public Sprite[] HeartSprites;
    public Image HeartUI;
    public Text Gameover;
    // Update is called once per frame
    void Update()
    {
        HeartUI.sprite = HeartSprites[health];
        if (health == 0)
        {
            Time.timeScale = 0;
            Debug.Log("Dead");
            Gameover.text = "Game Over!";
        }
    }
}
