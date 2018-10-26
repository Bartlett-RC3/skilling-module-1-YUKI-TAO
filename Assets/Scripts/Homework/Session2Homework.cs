using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SH2DogClass;

public class Session2Homework : MonoBehaviour {

    int number1 = 12;
    int number2 = 14;
    bool aBool = false;

    string[] studentNames = { "Lili", "Lala", "Lulu" ,"Hua","Jun"};


	// Use this for initialization
	void Start () {

        if (number1 < number2 && aBool == true)
        {
            Debug.Log("Answer to both questions is yes");

        }

        for (int i = 0; i <= studentNames.Length - 1; i++)
            {
                Debug.Log("A student is" + studentNames[i]);
            }

        //Write for a dog class and initialize an instance of the class 
        Dog Mydog = new Dog ("Huahua", "F", 1 , 6.2 );

        Debug.Log("My dog's name is" + Mydog.GetName());
        Debug.Log("My dog's gender is" + Mydog.GetGender());
        Debug.Log("My dog's age is" + Mydog.GetAge());
        Debug.Log("My dog's weight is" + Mydog.GetWeight());



    }


}
