using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class CUHKGameManager : singleton<CUHKGameManager> {
    private Player currentPlayer;
    private GameObject gui;
    private bool language = false; //false = ENG, true = CHINESE
    public bool panelsOn;

    public GameObject GUI
    {
        get
        {
            if (gui == null)
            {
                gui = GameObject.FindGameObjectWithTag("GUI");
            }
            return gui;
        }
        
    }

    public Player CurrentPlayer
    {
        get {
            if (currentPlayer == null)
            {
                currentPlayer = gameObject.AddComponent<Player>();
            }
            return currentPlayer;
        }
    }

    public bool Language
    {
        get { return language; }
        set { Language = language; }
    }

    public void toggleLanguage()
    {
        language = !language;
    }

    public string GetValueByKey(Dictionary<int, string> dict, int key)
    {
        if (dict.ContainsKey(key))
        {
            foreach (KeyValuePair<int, string> pair in dict)
            {
                if (key == pair.Key)
                {
                    return pair.Value;
                }
            }
            return "";
        }
        else return "";
    }

    public string GetValueByKey(Dictionary<string, string> dict, string key)
    {
        if (dict.ContainsKey(key))
        {
            foreach (KeyValuePair<string, string> pair in dict)
            {
                if (key == pair.Key)
                {
                    return pair.Value;
                }
            }
            return "";
        }
        else return "";
    }

    public int GetKeyByValue(Dictionary<int, string> dict, string value)
    {
        if (dict.ContainsValue(value))
        {
            foreach (KeyValuePair<int, string> pair in dict)
            {
                if (value == pair.Value)
                {
                    return pair.Key;
                }
            }
            return 0;
        }
        else return 0;
    }

    public void TranslateName(string poiname, string poiname_ch, Dictionary<string,string> poiDict_chi)
    {
        try
        {
            poiname_ch = GetValueByKey(poiDict_chi, poiname);
        }
        catch
        { }
    }


}
