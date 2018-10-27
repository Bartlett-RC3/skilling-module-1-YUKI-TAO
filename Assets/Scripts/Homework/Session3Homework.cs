using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3Homework : MonoBehaviour {


    public GameObject cubePrefab;
    public Material color;

    // Use this for initialization
    void Start()
    {
        cubePrefab = Instantiate(cubePrefab);

    }

    // Update is called once per frame
    void Update()
    {
        cubePrefab.transform.Translate(Vector3.down);

        if (Input.GetMouseButton(1))
        {
            color.color = new Color(Random.value, Random.value, Random.value);
        }
    }





}
