using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Session4Raycasting : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Ray direction
        Vector3 castedRayDirection = transform.TransformDirection(Vector3.forward);

        // Store the object that is in front
        RaycastHit objectInFront;

        // Ray casting
        if (Physics.Raycast(transform.position, castedRayDirection, out objectInFront))
        {
           
            Destroy(objectInFront.transform.gameObject);
        }

        // Move the cube up
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * 0.1f);
        }

        // Move the cube down
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * 0.1f);
        }

        //Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //Vector3 dir = mousePos - Camera.main.transform.position;
        //Ray ray = new Ray(Camera.main.transform.position, dir * 9999);

        //RaycastHit target;
        //if (Physics.Raycast(ray,out target, 99999f))
        //{
        //    if (target.transform.CompareTag("player"))
        //    {
        //        Destroy(target.transform.gameObject);
        //    }
        //}








    }
}
