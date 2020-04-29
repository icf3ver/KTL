using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {
    float x;
    float y;
    float z;
    public float elevation;
    Vector3 pos;

    void Start()
    {
        x = Random.Range(50, 450);
        z = Random.Range(50, 450);
        pos = new Vector3(x, elevation, z);
        transform.position = pos;
    }
}
