using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BManager : MonoBehaviour
{

    int multiplier = 2;
    int streak = 0;
    public GameObject note, win, lose;
    // to see whether note reach box collider
    public bool deductPoint = false;

    //miss 5 = loss
    int misses = 0;

  
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Note")
            note = col.gameObject;
        deductPoint = true;
        misses++;
        if (misses == 5){
            Lose();
        }
    }

   void Lose()
    {
        //lose game

        Debug.Log("lap saap");
    }

    public void Win()
    {
        //win game
        Debug.Log("So strong");
        if (PlayerPrefs.GetInt("Score") > 100)
        {
            win.SetActive(true);
        }

        else
            lose.SetActive(true);
    }

    public void AddStreak()
    {
        streak++;
        if (streak >= 15)
            multiplier = 6;
        else if (streak >= 10)
            multiplier = 4;
        else
            multiplier = 1;
        UpdateGUI();

    }

    public void ResetStreak()
    {
        streak = 0;
        multiplier = 1;
        UpdateGUI();
    }

    void UpdateGUI ()
    {
        PlayerPrefs.SetInt("Streak", streak);
        PlayerPrefs.SetInt("Multiplier", multiplier);
    }

    public int GetScore()
    {
        return 1 * multiplier;

    }
}
