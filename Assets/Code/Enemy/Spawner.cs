using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject spawner;
    public GameObject zed;
    public float timer;

    void Start(){
        timer = 5f;
    }

    void Update(){
        spawning();
        transform.Translate(new Vector3(0, -1, 0));
        transform.Rotate(new Vector3(0, 1, 0));
        transform.Translate(new Vector3(0, 1, 0));
    }

    void spawning(){
        timer -= Time.deltaTime;
        if (timer < 0){
            Instantiate(zed, spawner.transform.position, Quaternion.identity);
            timer = 3f;
        }
    }
}
