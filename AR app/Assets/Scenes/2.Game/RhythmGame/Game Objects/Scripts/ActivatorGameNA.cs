using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorGameNA : MonoBehaviour
{

    SpriteRenderer sr;
    public KeyCode key;
    bool active = false;
    GameObject note, gm;
    Color old;
    public bool createMode;
    public GameObject n;

    public bool ButtonClicked = false;


    void Awake()
    {
        sr = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        old = sr.color;
        gm = GameObject.Find("BManager");
        PlayerPrefs.SetInt("Score", 0);

    }

    void Update()
    {

        if (createMode)
        {
            if (Input.GetKeyDown(key) || ButtonClicked)
            {
                Instantiate(n, transform.position, Quaternion.identity);

            }
        }
        else
        {
            if (Input.GetKeyDown(key)|| ButtonClicked)
            {

                StartCoroutine(Pressed());
                Debug.Log("the button is clicked and passed to activator game");
            }
                

            if ((Input.GetKeyDown(key)||ButtonClicked) && active)
            {
                Destroy(note);
                gm.GetComponent<BManagerNA>().AddStreak();
                AddScore();
                active = false;
                Debug.Log("button clicked and note destroyed");
              
            }
            else if ((Input.GetKeyDown(key) || ButtonClicked) && !active)
            {
                gm.GetComponent<BManagerNA>().ResetStreak();
                PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")-1);

            }

        }

        if (ButtonClicked)
            ButtonClicked = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "WinNote")
        {
            gm.GetComponent<BManagerNA>().Win();

        }
       
        if (col.gameObject.tag == "Note")
        {
            note = col.gameObject;
            active = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (gm.GetComponent<BManagerNA>().deductPoint)
        {
            active = false;
            gm.GetComponent<BManagerNA>().deductPoint = false;
            gm.GetComponent<BManagerNA>().ResetStreak();
        }
    }
   
    public void Clicked()
    {
        ButtonClicked = true;
    }

    void AddScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + gm.GetComponent<BManagerNA>().GetScore());
    }

    IEnumerator Pressed()
    {
        sr.color = new Color(0,0,0);
        yield return new WaitForSeconds(0.05f);
        sr.color = old;
    }
}
