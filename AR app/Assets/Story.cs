using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Story : MonoBehaviour {

    [SerializeField] private TextMeshProUGUI storyText;

    public TextMeshProUGUI StoryText
    {
        get { return storyText; }
    }

    public void setText(int ID)
    {
        string a = "和聲";
        //storyText.text = StoryContent(ID);
        storyText.text = a;
    }

    public string StoryContent(int ID)
    {
        //Gate
        if (ID == 1)
        {
            return "The Gate of Wisdom is a piece of artwork placed in front of the University Library of CUHK. It was designed by Taiwanese sculptor Ju Ming in 1986 and was later gifted to CUHK. Since then, it has become one of the most iconic structures of CUHK. The appearance of the Gate of Wisdom resembles two fighters battling each other, which is a metaphor for fierce academic debates between scholars. There is a legend associated with the Gate of Wisdom, stating that students passing through the gate from the direction of the library will graduate with first class honour, while passing from the other direction will result in the inability in graduating (others say that passing through the gate from either direction will result in graduation with a miserable honour). Several major students movements also happened in the Gate of Wisdom, such as supporting the democratic movement in China in 1989 (June 4th Massacre) and the public consultation of the 2003 National Security Bill (Basic Law Article 23).";
        }
        //Woosing
        else if (ID == 2)
        {
            return "和聲";
        }
        //NA
        else if (ID == 3)
        {
            return "The New Asia Amphitheatre is well known for the names of all the past graduates engraved behind the stage. When no activities are being held in the amphitheatre, it serves as a resting spot for students to take a walk or sit down and listen to music at the auditorium. Several students activities including the banquet of a thousand people and the night of congee. Several large events also took place at the amphitheatre, such as the I.CARE Film Festival in 2014 (featuring Adam Wong, the director of the movie The Way We Dance) and the University Lecture on Civility in 2017-18, which invited the essayist and cultural critic Yingtai Lung as a speaker.";
        }
        //Lake
        else if (ID == 4)
        {
            return "Also named the Weiyuan Lake (the incomplete lake), the Lake Ad Excellentiam is located in the Chung Chi College. The name of the lake resembles incompleteness and implies the needs to search for perfection, which echoes the motto of the Chung Chi College: 止於至善 (keep going until perfection is achieved). The path leading to the lake from the University station is called the philosophy path, which encourages people to think about philosophy when they are taking a walk around the bridge. The red, octagon pavilion located at the centre is called the Lion Pavilion. The pond located next to the Lake Ad Excellentiam is called 養德池 (Lake of the Cultivation of Virtue). It is also called 養鴨池 (Lake of the Cultivation of Ducks), which is a pun since the Cantonese pronunciation of “德” sounds like the English word “duck”. The names of the two bridges on the lake carry philosophical meanings: the Crooked Bridge and the Arched Bridge resemble the roller-coaster experience of everyone’s life. However, one can always overcome the obstacles and cross the to the other side.";
        }
        //
        else return "";
    }
}
