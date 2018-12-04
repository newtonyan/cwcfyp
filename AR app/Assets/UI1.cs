using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UI1 : MonoBehaviour
{

    [SerializeField] private GameObject Male1;
    [SerializeField] private GameObject logo;
    [SerializeField] private int logoTime;
    [SerializeField] private int playerTime;

    private void Start()
    {
        StartCoroutine(logoCounter());
    }

    IEnumerator logoCounter()
    {
        yield return new WaitForSeconds(logoTime);
        logo.SetActive(!logo.activeSelf);
        StartCoroutine(playerCounter());
    }

    IEnumerator playerCounter()
    {
        yield return new WaitForSeconds(logoTime);
        SceneTransitionManager.Instance.GoToScene(CUHKConstants.SCENE_WORLD,new List<GameObject>());
    }


}
