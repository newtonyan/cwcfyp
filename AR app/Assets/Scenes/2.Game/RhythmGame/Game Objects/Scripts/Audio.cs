using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{


    /*void Awake()
    {
        AudioListener.pause = true;
    }*/

    public void OnValueChanged(float newValue)
    {
        float newVol = AudioListener.volume;
        newVol = newValue;
        AudioListener.volume = newVol;
    }
    private bool objectPlaced = false;

    public void PlayAudio(){
        if (!objectPlaced) {
            StartCoroutine(StartGameWait());
            
            objectPlaced = true;
        } 
    }

    public void pauseAudio(){
        AudioListener.pause= true;
    }


    public void resumeAudio(){
        AudioListener.pause = false;
    }

    IEnumerator StartGameWait()
    {
        Debug.Log(Time.time);
        yield return new WaitForSecondsRealtime(1);
        Debug.Log(Time.time);
        AudioSource gameAudio = GetComponent<AudioSource>();
        gameAudio.Play();
    }
}
