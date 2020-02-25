using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotSpawn : MonoBehaviour {

    public GameObject spawnPosObj;
    public GameObject shot;
    double timer = 0.25;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            if (Input.GetMouseButton(1))
            {
                Instantiate(shot, spawnPosObj.transform.position, spawnPosObj.transform.rotation);
                timer = 0.25f;
            }
        }
    }
}
