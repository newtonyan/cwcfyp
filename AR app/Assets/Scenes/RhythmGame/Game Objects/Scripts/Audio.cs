using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour {

    public GameObject Scrollbar;

    public void OnValueChanged(float newValue) {
        float newVol = AudioListener.volume;
        newVol = newValue;
        AudioListener.volume = newVol;
    }

    public void pauseAudio(){
        AudioListener.pause= true;
    }


    public void resumeAudio(){
        AudioListener.pause = false;
    }


}
