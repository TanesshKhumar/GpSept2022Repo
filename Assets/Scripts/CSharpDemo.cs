using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CSharpDemo : MonoBehaviour
{ 
    //Variables
    //<Acess modifier> <data type> <vaiable name>

    bool isGameEnd; //true/false
   public int points = 100;
    float mana = 2;

    string playerName = "ur mom";
    Vector3 direction = new Vector3(0.5f, 0.1f);

    public int[] intAray = new int[5];
    int[] intArray2 = new int[] { 1, 2, 3 };
    public List<string> nameList = new List <string>();
    public int[] arrayInspetor;
    char a = 'e';


    //functions/methods

    void AddPoints()
    {
        points++;
        //points +=1;


    }


    int MultiplyPointByTwo(int numToMultiply)
    {
        numToMultiply *= 2;
        return numToMultiply;
    }












    // Start is called before the first frame update
    void Start()
        
    {
        points = 0;

        for (int i = 0; i <5; i++)
        {

            Debug.Log(i);
        }

        for (int i = 0; i< intAray.Length; i++)
        {

            Debug.Log(intArray2[i]);
        }

        for (int i = 0; i< nameList.Count; i++)
        {

            Debug.Log(nameList[i]);
        }

        // for double click the tab




        int multipliedpoints = MultiplyPointByTwo(5);
        Debug.Log(MultiplyPointByTwo(5));

        string s = "My points are " + points;
        Debug.Log(s);
        Debug.Log("My points still are: " + points);

        //if point less than 50, OR points is an even number
        if (points < 50 || points % 2 == 0)
        {
            /* if (points % 2 == 0)
             {

                 Debug.Log("Aaauugh");

             } */
            Debug.Log("Git Gud");
        }
        //if point less than 100, AND points is an even number
        else if (points<100 && points % 2 == 0)
        {
            Debug.Log("Noice");
        }
        else
        {
            Debug.Log("Pog");
        }




        //Debug.Log(points);
        //AddPoints();
        // Debug.Log(points);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
