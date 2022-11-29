using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Newtonsoft.Json;
public enum TileType
{
    RED,
    BLUE,
    YELLOW
}


[System.Serializable]
public class TileData
{
    public int row;
    public int col;
    public TileType type;

   public TileData(int row, int col, TileType type)
    {
        this.row = row;
        this.col = col;
        this.type = type;
    }

    
}




public class TileGenerator : MonoBehaviour
{
   // public int maxRow;
   // public int maxCol;

    [SerializeField] float offSetX;
    [SerializeField] float offSetY;

    [SerializeField] Tile tilePrefab;

    [SerializeField] List<TileData> tileDataList = new List<TileData>();


    string jsonFilePath;
    void Awake()
    {
        jsonFilePath = Application.dataPath + @"\Prefabs\";
    }

   
    public void SaveToJson()
    {
        string jsonString = JsonConvert.SerializeObject(tileDataList);
        Debug.Log(jsonString);

        File.WriteAllText(jsonFilePath, jsonString);

    }
    public void LoadJson()
    {
        Debug.Log("LoadJson");
        if (File.Exists(jsonFilePath))
        {
            string loadedText = File.ReadAllText(jsonFilePath);
            tileDataList = JsonConvert.DeserializeObject<List<TileData>>(loadedText);
        }
    }

    //voidUpdate()
    //{
    //    if (Input.GetKeyDown(KeyCode.A))
    //    {
    //        GenerateTiles();

    //    }
    //    if (Input.GetKeyDown(KeyCode.S))
    //    {
    //       SaveToJson();

    //    }
    //    if (Input.GetKeyDown(KeyCode.L))
    //    {
    //        LoadJson();

    //    }
    //}

    public void GenerateTiles(int row, int col)
    {
        tileDataList.Clear();

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                TileType randType = (TileType)Random.Range(0, 3);
                TileData tileData = new TileData(i, j, randType);



                Tile tileObj = Instantiate(tilePrefab, new Vector3(tileData.col * offSetX, tileData.row* offSetY), Quaternion.identity);

                tileObj.data = tileData;
                tileObj.SetTileColor();

                tileDataList.Add(tileData);
            }

        }

    }

}
