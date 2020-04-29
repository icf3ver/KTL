using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {
    int cubeSpeed = 5;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.forward * cubeSpeed * Time.deltaTime);
        }
    }
}
