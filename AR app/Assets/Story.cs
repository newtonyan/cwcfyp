using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Story : MonoBehaviour {

    [SerializeField] private Text storyText;

    public Text StoryText
    {
        get { return storyText; }
    }

    public void setText(int ID)
    {
        storyText.text = StoryContent(ID);
    }

    public string StoryContent(int ID)
    {
        //Gate
        if (ID == 1)
        {
            return "Gate";
        }
        //Woosing
        else if (ID == 2)
        {
            return "The Lee Woo Sing College was founded in 2007 with the support from the Li Foundation (Bing Hua Tang). The college aims at developing leaders with local and global perspectives. The college also emphasizes the spirit of ‘Harmony’ (the Chinese name of the college is “和聲書院”, where “和聲” translates to harmony), which is marked by kindness and moderation, making it an essential quality of being a leader. The motto of the college is 知仁忠和 (wisdom, humanity, integrity and harmony), which is quoted from the Rites of Zhou, a ritual Confucian text.";
        }
        //NA
        else if (ID == 3)
        {
            return "NA";
        }
        //Lake
        else if (ID == 4)
        {
            return "Lake";
        }
        //
        else return "";
    }
}
