using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadDataScriptableObject : MonoBehaviour {

    [SerializeField]
    private DataObject data;


    void Start()
    {
        int a = data.dataID;
        string b = data.dataContent;

        Debug.Log(a);
        Debug.Log(b);
    }
}
