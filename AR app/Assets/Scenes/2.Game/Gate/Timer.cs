using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Timer : MonoBehaviour {
    public int timeLeft = 60;
    public Text countdownText;
    public Button endbut;
    public Text win;
    // Use this for initialization
    void Start () {
        StartCoroutine("LoseTime");
		
	}
	
	// Update is called once per frame
	void Update () {
        countdownText.text = ("Time Left : " + timeLeft);
        if (timeLeft <= 0)
        {
            StopCoroutine("LoseTime");
            Time.timeScale = 0;
            endbut.enabled = false;
            win.text = "You Win!"; 
        }
	}

    IEnumerator LoseTime()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
    }
}
