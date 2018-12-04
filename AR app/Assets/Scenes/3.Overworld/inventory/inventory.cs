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
            {"Chung Chi College","����WԺ"},
            {"New Asia College","����Ժ"},
            {"United College","�ϕ�Ժ"},
            {"Shaw College","�ݷ��Ժ"},
            {"Morningside College","���d��Ժ"},
            {"S.H. Ho College","�ƺ��Ժ"},
            {"C. W. Chu College","���ĕ�Ժ"},
            {"Wu Yee Sun College","���ˌO��Ժ"},
            {"Pavilion of Harmony","��һͤ"},
            //{"New Asia Concourse","���A�ΏV��"},
            {"New Asia Water Tower","��ˮ��"},
            {"University Gymnasium","��W�w���^"},
            {"Chung Chi Gate","����T"},
            {"University Science Centre","�ƌW�^"},
            {"Satellite Remote Sensing Receiving Station","UC��"},
            {"College Chapel","����WԺ�Y����"},
            {"The Four Pillars","�ėl��"}
        };
}
