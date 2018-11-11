using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI1 : MonoBehaviour
{

    public int time = 12;
    bool counting = true;

    [SerializeField] private GameObject Male1;
    public void Start()
    {
        StartCoroutine("LoseTime");
    }

    private void Update()
    {
        if (counting)
        {
            if (time <= 0)
            {
                StopCoroutine("LoseTime");
                counting = false;
                Male1.SetActive(!Male1.activeSelf);
                toggleNextScene();
            }
        }

    }

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            time--;
        }
    }


    public void toggleNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }



}
