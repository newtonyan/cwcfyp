namespace Mapbox.Examples
{
    using Mapbox.Unity.MeshGeneration.Interfaces;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.UI;

    public class Collectable : MonoBehaviour, IFeaturePropertySettable
    {
        private string poiname;
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
            {13, "New Asia Concourse"},
            {14, "New Asia Water Tower"},
            {15, "University Gymnasium"},
            {16, "Chung Chi Gate"},
            {17, "University Science Centre"},
            {18, "Satellite Remote Sensing Receiving Station"},
            {19, "College Chapel"},
            {20, "The Four Pillars"}
        };

        
        [SerializeField] private int id;

        public int Id
        {
            get { return id; }
        }

        public string Poiname
        {
            get { return poiname; }
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
            Debug.Log(poiname + " " + id);
        }

        void Start()
        {
            if (id != 16 && id != 20 && id != 14)
            {
                if (!poiDict.ContainsValue(poiname))
                {
                    Destroy(this.gameObject);
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
                }
            }

            if(id == 4)
            {
                if(poiLocalRank != "1")
                {
                    Destroy(this.gameObject);
                }
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
    }
}