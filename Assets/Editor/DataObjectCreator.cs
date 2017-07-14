using System.Collections;
using UnityEditor;
using UnityEngine;

public class DataObjectCreator : MonoBehaviour {

    [MenuItem("Assets/Create/Create Data Object")]
    public static void CreateAsset()
    {
        ScriptableObjectUtility.CreateAsset<DataObject>();
    }
}
