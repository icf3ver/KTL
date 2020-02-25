using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyWizardScript : MonoBehaviour {
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.forward * 10 * Time.deltaTime);
        
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }
}
