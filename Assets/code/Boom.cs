using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boom : MonoBehaviour {
    Renderer rend;
    public float boomTimer;
    public float flashTimer;
    public bool getBoomed = false;
    public RawImage img;
    public Health player;

    // Use this for initialization
    void Start () {
        //rend = GetComponent<Renderer>();
       // rend.material.shader = Shader.Find("Specular");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.GetComponent<Renderer>().material.color = new Color(255, 0, 0);
            boomTimer += Time.deltaTime;
            if (boomTimer > 5)
            {
                getBoomed = true;
                player.Fash();
                player.TakeDamage();
                //Fash();
                boomTimer = 0;
                Destroy(this.gameObject);

            }
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            this.GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            boomTimer = 0;
        }

    }
    //void Fash()
    //{
    //    for (int x = 255; x > 0; x -= 55)
    //    {
    //        img.color = new Color(255, 255, 255, x);
    //    }
    //        
    //}
}

//Code for flash is here
//put in start: 
// 
