using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Cube : MonoBehaviour
{
    public GameObject cubePrefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(cubePrefab, new Vector3(i*3, 0, 0), Quaternion.identity, this.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
