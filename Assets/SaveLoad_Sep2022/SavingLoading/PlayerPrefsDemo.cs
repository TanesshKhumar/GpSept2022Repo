using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPrefsDemo : MonoBehaviour
{
    public Button saveButton;
    public Button loadButton;
    public TextMeshProUGUI numberText;

    //save, load, delete
    public int number;

    private void Awake()
    {
        saveButton.onClick.AddListener(SaveNumber);
        loadButton.onClick.AddListener(LoadNumber);
        numberText.text = number.ToString();
    }

    public void SaveNumber()
    {
        Debug.Log("Save");
        PlayerPrefs.SetInt("myNumber", number);
    }

    public void LoadNumber()
    {
        number = PlayerPrefs.GetInt("myNumber");
        numberText.text = number.ToString();
    }
}
