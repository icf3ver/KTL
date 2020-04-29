using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boom : MonoBehaviour {
    Renderer rend;
    public float boomTimer;
    public float flashTimer;
    public RawImage img;
    public Health player;
    public ParticleSystem boom;

    void OnTriggerStay(Collider other){
        if (other.gameObject.CompareTag("Player")){
            boomTimer += Time.deltaTime;
            this.transform.parent.gameObject.GetComponent<Renderer>().material.color = new Color(255*(boomTimer/2), 0, 0);
            if (boomTimer > 2){
                Instantiate(boom, this.transform.position, Quaternion.identity);
                player.boomed();
                Destroy(this.transform.parent.gameObject.GetComponent<Renderer>().gameObject);
            }
        }
    }

    void OnTriggerExit(Collider other){
        if (other.gameObject.CompareTag("Player")){
            this.transform.parent.gameObject.GetComponent<Renderer>().GetComponent<Renderer>().material.color = new Color(0, 0, 0);
            boomTimer = 0;
        }
    }
}
