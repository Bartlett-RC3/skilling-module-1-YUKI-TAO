using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session3YUKI : MonoBehaviour {

    public GameObject cubePrefab;
    public GameObject Light;
    public int spacingX = 10;
    public int spacingZ = 10;
    public int x = 10;
    public int z = 10;

    // Use this for initialization
    void Start () {
		for(int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; i++)
            {
                Instantiate(cubePrefab, new Vector3(x * spacingX, 0.0f, z * spacingZ), Quaternion.identity, this.transform);
            }
        }
	}

    // Update is called once per frame
    void Update() {
        //Debug.Log("This computer can render a frame in:" + Time.deltaTime);
        //Debug.Log("Since I started playing the game this amount of time has passed:" + Time.timeSinceLevelLoad);
        //Debug.Log("Computer has counted this " + Time.frameCount);

        foreach (Transform child in this.transform)
        {

            child.Translate(0, 0, Random.Range(-1f, -1f));
        }
        //foreach (Transform child in this.transform)
        //{

        //    child.Rotate(0, Random.value, 0);
        //}
        //foreach (Transform child in this.transform)
        //{

        //    child.RotateAroundLocal(Vector3.up,Random.value);
        //}
        //foreach (Transform child in this.transform)
        //{

        //    child.localScale = new Vector3(Random.Range(0.1f,1),);
        //}
        //Vector3[] os = new Vector3[this.transform.childCount];
       

        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    foreach (Transform child in this.transform)
        //    {
        //        child.localScale = child.localScale * 10f;
        //    }
        //}else
        //for (int i = 0, i< transform, i++)
        //{
        //    os[i] = transform.GetChild(i).lossyScale;

        //}

        //if (Input.GetMouseButton(0))
        //{
        //    light.GetComponent<Light>().color = new Color(Random.Range(0, 255));
        //}

    }


}
