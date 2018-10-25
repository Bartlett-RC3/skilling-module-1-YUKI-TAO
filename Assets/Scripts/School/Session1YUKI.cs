using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session1YUKI : MonoBehaviour {

    // 1.Variables
    // Scope -- Type -- Name -- Value
    //scope→public or private
   
    //Numbers
    int myInteger = 145;
    int largest = int.MaxValue;
    int smallest = int.MinValue;

    double myDouble = 54.3;
    double maxDouble = double.MaxValue;

    float myFloat = 32.456f;
    float maxFloat = float.MaxValue;

    //Text
    string myString = "dididi";

    //Logical
    bool myBoolean = true;
    bool falseBoolean = false;

    //2.Data structures
    // Scope -- Type -- Values（can take in many values）
    // 区别：1.Array类型的变量在声明的同时必须进行实例化(至少得初始化数组的大小)，而List可以只是先声明。
         
    //Array 的几种声明方式
    int[] myIntArray = { 1, 2, 3, 4, 5};//确定了数组的初值及长度
    int[] twentyElementsArray = new int[20];//只确定了数组的长度
    int[] threeElementsArray = new int[3] { 1, 2, 3 };//确定了数组的初值和长度
    int[,] xyArray = new int[4, 5];

    double[] doubleArray = { 10.4, 11.23, 45 };

    //List
    List<int> myList = new List<int>();

    //Dictionary<[key], [value]>
    Dictionary<string, string> movingAnimals = new Dictionary<string, string>();


    // 3.Functions
    // Scope -- Type -- Variables -- Body (Instructions)


    // Use this for initialization
    void Start () {
        // array adding values给数组赋值
        myIntArray[2] = 300;
        //array retrive values从数组取值
        Debug.Log(myIntArray[1].ToString());

        //list adding values给list赋值
        myList.Add(4321);
        myList.Add(41);
        myList.Add(1);
        //list retrive values从list取值
        Debug.Log(myList[2].ToString());
        Debug.Log(myList[myList.Count-1].ToString());
        //clearing the list清空
        myList.Clear();


        //给dictionary赋值
        movingAnimals.Add("aaa", "bbb");
        movingAnimals.Add("ccc", "eee");
        //查找
        if(movingAnimals.ContainsKey("aaa"));
        Debug.Log("A flying animal is :" + movingAnimals.Values);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    // 3.Number addtion function
    // Scope -- Type -- name -- Variables -- Body (Instructions)
    float NumberAddition(float a,float b)
    {
        // return a + b;
        float additionResult = a + b;
        return additionResult;
    }

    void PrintSomeNumbers()
    {
        Debug.Log(myList[0]);
        
    }


}
