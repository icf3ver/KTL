using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour {

   
    // Use this for initialization
    void Start()
    {
        Screen.lockCursor = true;
    }

    // Update is called once per frame
    void Update()
    {

        float translation = Input.GetAxis("Mouse Y");
        float rotation = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotation, 0));

        if (rotation != 0)
        {
            //Debug.Log("Turning!");
        }

        if (Input.GetKeyDown("space"))
        {
            //Debug.Log("space key was pressed");
        }

        //print(translation);
        //print(rotation);
    }
}
