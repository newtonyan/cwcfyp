namespace Mapbox.Examples
{
    using Mapbox.Unity.MeshGeneration.Interfaces;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;
    using TMPro;
    using UnityEngine.EventSystems;
    using System.Collections;

    public class Collectable : MonoBehaviour, IFeaturePropertySettable
    {
        private string poiname;
        private string poiname_ch;
        private string poiLocalRank;
        /*private string[] poiList = new string[] {
            "Chung Chi College",
            "New Asia College",
            "United College",
            "Shaw College",
            "Morningside College",
            "S.H. Ho College",
            "C. W. Chu College",
            "Wu Yee Sun College",
            "Pavilion of Harmony",
            "New Asia Concourse",
            "University Gymnasium",
            "University Science Centre",
            "Satellite Remote Sensing Receiving Station",
            "College Chapel"
        };*/
        Dictionary<int, string> poiDict = new Dictionary<int, string>() {
            {1,"Chung Chi College"},
            {2, "New Asia College"},
            {3, "United College"},
            {4, "Shaw College"},
            {5, "Morningside College"},
            {6, "S.H. Ho College"},
            {7, "C. W. Chu College"},
            {8, "Wu Yee Sun College"},
            {12, "Pavilion of Harmony"},
            //{13, "New Asia Concourse"},
            {14, "New Asia Water Tower"},
            {15, "University Gymnasium"},
            {16, "Chung Chi Gate"},
            {17, "University Science Centre"},
            {18, "Satellite Remote Sensing Receiving Station"},
            {19, "College Chapel"},
            {20, "The Four Pillars"}
        };

        Dictionary<string, string> poiDict_chi = new Dictionary<string, string>() {
            {"Chung Chi College","崇基學院"},
            {"New Asia College","新亞書院"},
            {"United College","聯合書院"},
            {"Shaw College","逸夫書院"},
            {"Morningside College","晨興書院"},
            {"S.H. Ho College","善衡書院"},
            {"C. W. Chu College","敬文書院"},
            {"Wu Yee Sun College","伍宜孫書院"},
            {"Pavilion of Harmony","合一亭"},
            //{"New Asia Concourse","新亞圓形廣場"},
            {"New Asia Water Tower","新亞水塔"},
            {"University Gymnasium","大學體育館"},
            {"Chung Chi Gate","崇基門"},
            {"University Science Centre","科學館"},
            {"Satellite Remote Sensing Receiving Station","UC波"},
            {"College Chapel","崇基學院禮拜堂"},
            {"The Four Pillars","四條柱"}
        };

        private bool collected = false;

        [SerializeField] private int id;
        [SerializeField] TextMeshPro text;

        [SerializeField] private Material[] materials;
        private MeshRenderer mrend;


        public int Id
        {
            get { return id; }
        }

        public string Poiname
        {
            get { return poiname; }
        }

        public string Poiname_ch
        {
            get { return poiname_ch; }
        }

        public string PoiLocalRank
        {
            get { return poiLocalRank; }
        }

        /*public string[] PoiList
        {
            get { return poiList; }
        }*/

        public void Set(Dictionary<string, object> props)
        {
            if (props.ContainsKey("name_en"))
            {
                poiname = props["name_en"].ToString();
            }

            if (props.ContainsKey("localrank"))
            {
                poiLocalRank = props["localrank"].ToString();
            }      
        }



        private void OnMouseDown()
        {
            //StartCoroutine(PressDelay());   
            if (!CUHKGameManager.Instance.CurrentPlayer.collectableExist(id))
            {
                CUHKSceneManager[] sceneManagers = FindObjectsOfType<CUHKSceneManager>();
                foreach (CUHKSceneManager manager in sceneManagers)
                {
                    if (manager.gameObject.activeSelf)
                    {
                        manager.collectableTapped(id);
                    }
                }
                mrend.sharedMaterial = materials[id - 1];
            }
            else Debug.Log(poiname + " exists already!");

            CUHKGameManager.Instance.GUI.GetComponent<UIManage>().toggleStory(id);
            Debug.Log(poiname + " " + poiname_ch + " " + id);
        }

        void Start()
        {         
            //DontDestroyOnLoad(this);
            mrend = GetComponent<MeshRenderer>();
            if (id != 16 && id != 20 && id != 14)
            {
                if (!poiDict.ContainsValue(poiname))
                {
                    Destroy(this.gameObject);
                    return;
                }
                else
                {
                    id = GetKeyByValue(poiDict,poiname);
                }
            }
            else
            {
                poiname=GetValueByKey(poiDict, id);
            }

            if(id == 5 || id == 8)
            {
                if(poiLocalRank != "2")
                {
                    Destroy(this.gameObject);
                    return;
                }
            }

            if(id == 4)
            {
                if(poiLocalRank != "1")
                {
                    Destroy(this.gameObject);
                    return;
                }
            }

            TranslateName();

            if (CUHKGameManager.Instance.Language)
            {
                text.SetText(poiname_ch);
            }
            else
            {
                text.SetText(poiname);
            }

            if (CUHKGameManager.Instance.CurrentPlayer.collectableExist(id))
            {
                mrend.sharedMaterial = materials[id-1];
            }
        }


        void Update()
        {
            if (CUHKGameManager.Instance.panelsOn)
            {
                BoxCollider bc = GetComponent<BoxCollider>();
                bc.enabled = false;
            }
            else
            {
                BoxCollider bc = GetComponent<BoxCollider>();
                bc.enabled = true;
            }
        }

        private string GetValueByKey(Dictionary<int, string> dict,int key) 
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

        private string GetValueByKey(Dictionary<string, string> dict, string key)
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

        private int GetKeyByValue(Dictionary<int, string> dict, string value)
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

        private void TranslateName()
        {
            try
            {
                poiname_ch = GetValueByKey(poiDict_chi, poiname);
            }
            catch
            {}         
        }


       

    }
}