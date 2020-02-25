using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombySpawner : MonoBehaviour {
    public GameObject spawnPos;
    public GameObject zomby;
    public float timerTime;
    // Use this for initialization
    void Start () {
        timerTime = 5f;
    }
	
	// Update is called once per frame
	void Update () {
        
        spawn();
        
        transform.Rotate(new Vector3(0, 1, 0));
        
    }

    void spawn()
    {
        timerTime -= Time.deltaTime;
        if(timerTime < 0)
        {
            Instantiate(zomby, spawnPos.transform.position, Quaternion.identity);
            timerTime = 3f;
        }
    }
}
