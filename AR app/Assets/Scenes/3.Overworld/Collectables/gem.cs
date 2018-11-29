using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gem : MonoBehaviour {

    [SerializeField] private int bonus = 10;

    private void OnMouseDown()
    {
        CUHKGameManager.Instance.CurrentPlayer.AddCredit(bonus);
        Destroy(gameObject);
    }
}
