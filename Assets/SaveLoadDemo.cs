using Newtonsoft.Json;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string playerName;
    public int playerScore;
    public bool finishedGame;
}

public class SaveLoadDemo : MonoBehaviour
{
    public PlayerData currentPlayer;
    public List<PlayerData> currentPlayers;
    string jsonFilePath = Application.dataPath + @"\Prefabs\";
    string xmlFilePath = @"C:\Users\UOW\Sep2022_GP\Assets\SaveLoadEditor\SaveDataXML.xml";

    public void SaveToJson()
    {
        string jsonString = JsonConvert.SerializeObject(currentPlayers);
        Debug.Log(jsonString);

        File.WriteAllText(jsonFilePath, jsonString);

    }
    public void LoadJson()
    {
        Debug.Log("LoadJson");
        if (File.Exists(jsonFilePath))
        {
            string loadedText = File.ReadAllText(jsonFilePath);
            currentPlayers = JsonConvert.DeserializeObject<List<PlayerData>>(loadedText);
        }
    }
    public void SaveXML()
    {
        Debug.Log($"SaveXML");
        XmlSerializer serializer = new XmlSerializer(typeof(List<PlayerData>));

        //similar to write all text
        FileStream stream =
            new FileStream(xmlFilePath, FileMode.Create);

        serializer.Serialize(stream, currentPlayers);
        stream.Close();

    }

    public void LoadXML()
    {
        Debug.Log($"LoadXML");
        XmlSerializer serializer = new XmlSerializer(typeof(List<PlayerData>));
        FileStream stream = new FileStream(xmlFilePath, FileMode.Open);
        currentPlayers = (List<PlayerData>)serializer.Deserialize(stream);
        stream.Close();
    }

    //// Update is called once per frame
    //void Update()
    //{
    //    if (Input.GetKeyDown(KeyCode.S))
    //    {
    //        SaveToJson();
    //    }
    //    if (Input.GetKeyDown(KeyCode.L))
    //    {
    //        LoadJson();
    //    }
    //}
}
