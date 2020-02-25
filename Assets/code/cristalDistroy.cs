using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cristalDistroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("shot"))
        {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
        
    }
}
