using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Vuforia
{
    public class appear : MonoBehaviour, ITrackableEventHandler

    {
        private TrackableBehaviour mTrackableBehaviour;

        void Start()
        {
            mTrackableBehaviour = GetComponent<TrackableBehaviour>();
            if (mTrackableBehaviour)
            {
                mTrackableBehaviour.RegisterTrackableEventHandler(this);
            }
        }

        public void OnTrackableStateChanged(TrackableBehaviour.Status previousStatus, TrackableBehaviour.Status newStatus)
        {
            if (newStatus == TrackableBehaviour.Status.DETECTED ||
                newStatus == TrackableBehaviour.Status.TRACKED ||
                newStatus == TrackableBehaviour.Status.EXTENDED_TRACKED)
            {
                // Play audio when target is found
                Debug.Log("Helloworld");
            }
            else
            {
                // Stop audio when target is lost
                Debug.Log("diu");
            }
        }
    }
}
