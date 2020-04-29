using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    void Start(){
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update(){
        float rotation = Input.GetAxis("Mouse X");

        transform.Rotate(new Vector3(0, rotation, 0));

        if (Input.GetKeyDown("l")){
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }

    }
}
