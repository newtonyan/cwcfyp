using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mapbox.Utils;

public class MapZone : MonoBehaviour {

    Dictionary<string, string> zone_ch = new Dictionary<string, string>() {
            {"Chung Chi College","崇基學院"},
            {"New Asia College","新亞書院"},
            {"United College","聯合書院"},
            {"Shaw College","逸夫書院"},
            {"S.H. Ho College and Morningside College","善衡書院和晨興書院"},
            {"C. W. Chu College","敬文書院"},
            {"Wu Yee Sun College","伍宜孫書院"},
            { "Lee Woo Sing College","和聲書院" },     
            {"Lake Ad Excellentiam","未圓湖"},
            {"Main Campus (Library Area)","本部(圖書館)"},
            {"Main Campus (Science Centre Area)","本部(科學館)"},
            {"University Gym and Postgraduate Hall 1","大學體育館和研究生宿舍"},
            {"I-House and Staff Residence","國際生舍堂和教職員宿舍"},
            {"Campus Circuit East","環迴東路"},
            {"University Station","大學站" }
        };

    public string GetValueByKey(string key)
    {
        if (zone_ch.ContainsKey(key))
        {
            foreach (KeyValuePair<string, string> pair in zone_ch)
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

    public string GetAreaName(Vector2d location)
    {
        double x = location.x;
        double y = location.y;

        if (22.411231 < x && x < 22.414501 && 114.208312 < y && y < 114.212441)
            return "University Station";

        else if (22.414501 < x && x < 22.416512 && 114.208312 < y && y < 114.210250)
            return "Lake Ad Excellentiam";

        else if (22.411231 < x && x < 22.417603 && 114.203384 < y && y < 114.212441)
            return "Chung Chi College";

        else if (22.417603 < x && x < 22.420543 && 114.200270 < y && y < 114.206499)
            return "Main Campus (Library Area)";

        else if (22.417603 < x && x < 22.420543 && 114.206499 < y && y < 114.209560)
            return "Main Campus (Science Centre Area)";

        else if (22.417603 < x && x < 22.420543 && 114.209560 < y && y < 114.210916)
            return "S.H. Ho College and Morningside College";

        else if (22.417603 < x && x < 22.420543 && 114.210916 < y && y < 114.212441)
            return "University Gym and Postgraduate Hall 1";

        else if (22.420543 < x && x < 22.428408 && 114.200270 < y && y < 114.202128)
            return "Shaw College";

        else if (22.420543 < x && x < 22.422982 && 114.202128 < y && y < 114.203384)
            return "Wu Yee Sun College";

        else if (22.421094 < x && x < 22.422982 && 114.203384 < y && y < 114.204725)
            return "Lee Woo Sing College";

        else if (22.420543 < x && x < 22.422982 && 114.203384 < y && y < 114.207320)
            return "United College";

        else if (22.420543 < x && x < 22.422982 && 114.207320 < y && y < 114.210916)
            return "New Asia College";

        else if (22.420543 < x && x < 22.428408 && 114.210916 < y && y < 114.212441)
            return "Campus Circuit East";

        else if (22.425088 < x && x < 22.428408 && 114.202128 < y && y < 114.207320)
            return "C. W. Chu College";

        else if (22.422982 < x && x < 22.428408 && 114.202128 < y && y < 114.201916)
            return "I-House and Staff Residence";

        else
            return "not in CUHK";
    }
}