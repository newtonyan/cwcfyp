using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

public class inventory : MonoBehaviour {

    [SerializeField] private float floatAmp = 2.0f;
    [SerializeField] private float floatFreq = 0.5f;
    [SerializeField] private int collectableID;

    [SerializeField] private Material materials;
    private MeshRenderer mrend;

    public int CollectableID
    {
        get { return collectableID; }
    }


    private void Start()
    {
        mrend = GetComponent<MeshRenderer>();
    }

    void Update()
    {
        float angle = Mathf.Sin(Time.fixedTime * Mathf.PI * floatFreq) * floatAmp * 2;
        transform.RotateAround(transform.position,Vector3.up, angle);
    }

    public void checkStatus()
    {
        if (CUHKGameManager.Instance.CurrentPlayer.collectableExist(collectableID))
        {
            Debug.Log(collectableID.ToString() + "change colour");
            mrend.material = materials;
            
        }
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
}
