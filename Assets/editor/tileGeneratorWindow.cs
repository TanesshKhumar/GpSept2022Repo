
using UnityEngine;
using UnityEditor;






public class tileGeneratorWindow : EditorWindow
{
    int row;
    int col;

    [MenuItem("MyTools/TileGenerator")]

    public static void ShowWindow()
    {
        EditorWindow.GetWindow<tileGeneratorWindow>("TileGenerator");
    }

    private void OnGUI()
    {
        GUILayout.Label("Configure Your tile map here", EditorStyles.boldLabel);

        row = EditorGUILayout.IntField("Number of rows: ", row);
        col = EditorGUILayout.IntField("Number of colums: ", col);

        if (GUILayout.Button("Generate Title Data"))
        {
            FindObjectOfType<TileGenerator>().GenerateTiles(row, col);
                
        }
    }
}
