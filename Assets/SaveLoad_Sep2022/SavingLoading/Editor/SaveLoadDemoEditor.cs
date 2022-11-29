using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(SaveLoadDemo))]
public class SaveLoadDemoEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        SaveLoadDemo saveLoadDemo = (SaveLoadDemo)target;

        if (GUILayout.Button("Save JSON"))
        {
            saveLoadDemo.SaveToJson();
        }
        if (GUILayout.Button("Load JSON"))
        {
            saveLoadDemo.LoadJson();
        }
    }
}
