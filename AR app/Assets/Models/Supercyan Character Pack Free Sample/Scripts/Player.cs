using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    [SerializeField] private int credit = 0;
    [SerializeField] private int requiredCredit = 123;
    [SerializeField] private int levelBase = 100;
    [SerializeField] private List<GameObject> collectables = new List<GameObject>();
    private int lvl = 1;

    public int Lvl
    {
        get { return lvl; }
    }

    public int Credit
    {
        get { return credit; }
    }

    public int RequiredCredit
    {
        get { return requiredCredit; }
    }

    public int LevelBase
    {
        get { return levelBase; }
    }

    public List<GameObject> Collectables
    {
        get { return collectables; }
    }

    // Use this for initialization
    void Start () {
        //DontDestroyOnLoad(this);
	}
	
    public void AddCredit(int credit)
    {
        this.credit += Mathf.Max(0, credit);
    }

    public void AddCollectables(GameObject collectable)
    {
        collectables.Add(collectable);
    }

    public bool collectableExist(GameObject collectable)
    {
        if (collectables.Contains(collectable))
        {
            return true;
        }
        else return false;
    }

}
