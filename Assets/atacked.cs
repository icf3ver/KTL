using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class atacked : MonoBehaviour {

    public ParticleSystem particle;
    public float timer;
	
    // Use this for initialization
	void Start () {
        particle.Stop();
        timer = 1f;
    }
	
	// Update is called once per frame
	void Update () {
        


    }
    void OnCollisionEnter(Collision col)
    {
        //Debug.Log("working");
        if (col.gameObject.CompareTag("Player"))
        {
            
            Debug.Log("hit");
                particle.Play();
            
        }

    }
    void OnCollisionExit(Collision col)
    {
        if (col.gameObject.CompareTag("Player"))
        {

            Debug.Log("hit");
            particle.Stop();

        }
    }

}
