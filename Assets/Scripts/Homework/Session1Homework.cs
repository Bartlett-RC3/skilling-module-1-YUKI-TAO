using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1Homework : MonoBehaviour {

    int myInteger = 12;
    float myFloat = 12.22f;
    string myString = "YUKI";

    int[] myIntArray =new int [6]{ 1, 2, 3, 4, 5, 6 };

    List<double > myList = new List<double >();

    Dictionary<int, string> myDictionary = new Dictionary<int, string>();

   
    // Use this for initialization
    void Start () {
        myList.Add(12.2);
        myList.Add(15.4);

        myDictionary.Add(1, "lili");
        myDictionary.Add(2, "lulu");

        Debug.Log(myFloat);
        Debug.Log(myInteger);
        Debug.Log(myString);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    

}
