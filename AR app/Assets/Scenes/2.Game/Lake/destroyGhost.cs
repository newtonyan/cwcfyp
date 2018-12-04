using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyGhost : MonoBehaviour {

    [SerializeField] GameObject GUI;

    void OnCollisionEnter(Collision col)
    {
        Debug.Log(col.gameObject.tag);
        if (col.gameObject.tag == "Bullet")
        {
            gameObject.SetActive(false);
            GUI.GetComponent<Game4UIManager>().getHit();
            PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score") + 10);
        }
    }
}
