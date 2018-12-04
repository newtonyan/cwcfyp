using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class inventoryHitBox : MonoBehaviour {

    [SerializeField] private int collectableID;
    [SerializeField] private TextMeshProUGUI collectableLocationText;
    [SerializeField] private GameObject masterGem;
    [SerializeField] private GameObject masterStone;

    [SerializeField] private Material[] materials;
    private MeshRenderer mrend;

    public void showDetail()
    {
        if(collectableID != 9 && collectableID != 10 && collectableID != 11 && collectableID != 13)
        {
            mrend = masterGem.GetComponent<MeshRenderer>();
            masterGem.SetActive(true);
            if (masterStone.activeSelf)
            {
                masterStone.SetActive(false);
            }
        }
        else
        {
            mrend = masterStone.GetComponent<MeshRenderer>();
            masterStone.SetActive(true);
            if (masterGem.activeSelf)
            {
                masterGem.SetActive(false);
            }
        }
            
        mrend.sharedMaterial = materials[collectableID - 1];
        if (CUHKGameManager.Instance.Language)
        {
        collectableLocationText.text = CUHKGameManager.Instance.GetValueByKey(poiDict_chi, collectableID);
        }
        else collectableLocationText.text = CUHKGameManager.Instance.GetValueByKey(poiDict, collectableID);
    }

    Dictionary<int, string> poiDict = new Dictionary<int, string>() {
            {1,"Chung Chi College"},
            {2, "New Asia College"},
            {3, "United College"},
            {4, "Shaw College"},
            {5, "Morningside College"},
            {6, "S.H. Ho College"},
            {7, "C. W. Chu College"},
            {8, "Wu Yee Sun College"},
            {9, "Lee Woo Sing College"},
            {10,"Gate of Wisdom"},
            {11,"Lake Ad Excellentiam"},
            {12, "Pavilion of Harmony"},
            {13, "New Asia Concourse"},
            {14, "New Asia Water Tower"},
            {15, "University Gymnasium"},
            {16, "Chung Chi Gate"},
            {17, "University Science Centre"},
            {18, "Satellite Remote Sensing Receiving Station"},
            {19, "College Chapel"},
            {20, "The Four Pillars"}
        };

    Dictionary<int, string> poiDict_chi = new Dictionary<int, string>() {
            {1,"崇基學院"},
            {2,"新亞書院"},
            {3,"聯合書院"},
            {4,"逸夫書院"},
            {5,"晨興書院"},
            {6,"善衡書院"},
            {7,"敬文書院"},
            {8,"伍宜孫書院"},
            {9,"和聲書院"},
            {10,"仲門"},
            {11,"未圓湖"},
            {12,"合一亭"},
            {13,"新亞圓形廣場"},
            {14,"新亞水塔"},
            {15,"大學體育館"},
            {16,"崇基門"},
            {17,"科學館"},
            {18,"UC波"},
            {19,"崇基學院禮拜堂"},
            {20,"四條柱"}
        };

}
