using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

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
        
        if (Input.GetKeyDown("l"))
        {
            Screen.lockCursor = true;
        }

        //print(translation);
        //print(rotation);
    }
}
