using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Session2YUKI : MonoBehaviour {

    int number1 = 10;
    int number2 = 20;
    int number3 = 30;
    bool someBool = false;
    string someName = "name";
    string[] tutorNames = { "Dave", "Tyson", "Jordi","Octavian","Panos"};

   

	// Use this for initialization
	void Start () {

        Debug.Log("A tutor is" + tutorNames[0]);
        Debug.Log("A tutor is" + tutorNames[1]);
        Debug.Log("A tutor is" + tutorNames[2]);

        for (int i = 0; i <= tutorNames.Length - 1; i++)
        {
            Debug.Log("A tutor is" + tutorNames[i]);
        }

        for(int counter = 0; counter <= number2; counter++)
        {
            Debug.Log("counter..." + counter);
        }

        foreach(string tutorName in tutorNames)
        {
            Debug.Log(tutorName);
        }



        if (number1 < number2)
        {
            Debug.Log("number1 is bigger than number2");

        }
        else
        {
            Debug.Log("number2 is bigger than number1");
        }


        if (number1 < number2 && someBool == true)
        {
            Debug.Log("Answer to both questions is yes");

        }

        if (number1 < number2)
        {
            if (someBool == true)
            {
                Debug.Log("Answer to both questions is yes");
            }
        }

        if (number1 < number2 || someBool == true)
        {
            Debug.Log("Answer to one of the questions is yes");
        }

        if ((number1 < number2 && someBool == true) && (someBool == true && someName == "name"))
        {
            Debug.Log("this is too confusing! simply please!");
        }

        number3 = (number1 < number2) ? 100 : 200;
     

        

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
