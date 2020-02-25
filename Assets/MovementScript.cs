using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour {
    
    // Use this for initialization
    int cubeSpeed = 5;
    float ajustSpeed = 0.5f;
    Vector3 moveSpeed = new Vector3(1, 1, 1);
    Vector3 mouseTarg;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        if (Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.forward * cubeSpeed * Time.deltaTime);
        }
        

        //mouseTarg = new Vector3(Input.mousePosition.x, Input.mousePosition.y,);
    }
}
