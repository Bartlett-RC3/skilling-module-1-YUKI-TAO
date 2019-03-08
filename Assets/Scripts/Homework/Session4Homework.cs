using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Homework : MonoBehaviour
{
    private MeshRenderer meshRender;
    // Start is called before the first frame update
    void Start()
    {
        meshRender = GetComponent<MeshRenderer>();
        StartCoroutine(ChangeColors());
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator ChangeColors()
    {
        yield return new WaitForSeconds(1f);
        meshRender.material.color = Color.blue;     //蓝 红 黑 三色切换
        yield return new WaitForSeconds(1f);
        meshRender.material.color = Color.red;
        yield return new WaitForSeconds(1f);
        meshRender.material.color = Color.yellow;
        yield return StartCoroutine(ChangeColors());
    }
}
            
