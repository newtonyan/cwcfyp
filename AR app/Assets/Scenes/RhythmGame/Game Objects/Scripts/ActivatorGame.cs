using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatorGame : MonoBehaviour
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
            }
                

            if ((Input.GetKeyDown(key)||ButtonClicked) && active)
            {
                Destroy(note);
                gm.GetComponent<BManager>().AddStreak();
                AddScore();
                active = false;
              
            }
            else if ((Input.GetKeyDown(key) || ButtonClicked) && !active)
            {
                gm.GetComponent<BManager>().ResetStreak();

            }

        }

        if (ButtonClicked)
            ButtonClicked = false;
    }

    void OnTriggerEnter2D(Collider2D col)
    {

        if (col.gameObject.tag == "WinNote")
        {
            gm.GetComponent<BManager>().Win();

        }

        if (col.gameObject.tag == "Note")
        {
            note = col.gameObject;
            active = true;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {

        if (gm.GetComponent<BManager>().deductPoint)
        {
            active = false;
            gm.GetComponent<BManager>().deductPoint = false;
            gm.GetComponent<BManager>().ResetStreak();
        }
    }

    public void Clicked()
    {
        ButtonClicked = true;
        Debug.Log("clicked");
    }

    void AddScore()
    {
        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + gm.GetComponent<BManager>().GetScore());
    }

    IEnumerator Pressed()
    {
        sr.color = new Color(0, 0, 0);
        yield return new WaitForSeconds(0.05f);
        sr.color = old;
    }
}
