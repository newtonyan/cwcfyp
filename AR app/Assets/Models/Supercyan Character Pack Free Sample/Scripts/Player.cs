using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Player : MonoBehaviour {

    [SerializeField] private int credit = 0;
    [SerializeField] private int requiredCredit = 123;
    [SerializeField] private List<int> collectables = new List<int>();
    private int lvl = 1;

    private string path;

    public int Lvl
    {
        get { return lvl; }
    }

    public int Credit
    {
        get { return credit; }
        //set { credit = Credit; }
    }

    public int RequiredCredit
    {
        get { return requiredCredit; }
    }


    public List<int> Collectables
    {
        get { return collectables; }
        //set { collectables = Collectables; }
    }

    // Use this for initialization
    void Start () {
        path = Application.persistentDataPath + "/player.dat";
        //load();
        InitLevelData();
    }

    public void InitLevelData()
    {
        lvl = credit / 31 + 1;
    }
	
    public void AddCredit(int credit)
    {
        this.credit += Mathf.Max(0, credit);
        InitLevelData();
        //Save();
    }

    public void AddCollectables(int collectable)
    {
        collectables.Add(collectable);
        InitLevelData();
        //Save();
    }

    public bool collectableExist(int collectable)
    {
        if (collectables.Contains(collectable))
        {
            return true;
        }
        else return false;
    }

    private void Save()
    {
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(path);
        PlayerData data = new PlayerData(this);
        bf.Serialize(file, data);
        file.Close();

    }

    /*private void Clear()
    {
        Player resetPlayer = new Player();
        resetPlayer.Credit = 0;
        resetPlayer.Collectables = new List<int>();
        BinaryFormatter bf = new BinaryFormatter();
        FileStream file = File.Create(path);
        PlayerData data = new PlayerData(resetPlayer);
        bf.Serialize(file, data);
        file.Close();

    }*/

    private void load()
    {
        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream file = File.Open(path, FileMode.Open);
            PlayerData data = (PlayerData)bf.Deserialize(file);
            file.Close();

            credit = data.Credit;
            collectables = data.Collectables;
        }
        else
        {
            InitLevelData();
        }
    }

}
