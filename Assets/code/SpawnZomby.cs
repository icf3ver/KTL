using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZomby : MonoBehaviour {

    public GameObject spawner;
    public GameObject zed;
    public float timer;
    // Use this for initialization
    void Start()
    {
        timer = 5f;
    }

    // Update is called once per frame
    void Update()
    {

        spawning();
        transform.Translate(new Vector3(0, -1, 0));
        transform.Rotate(new Vector3(0, 1, 0));
        transform.Translate(new Vector3(0, 1, 0));
    }

    void spawning()
    {
        timer -= Time.deltaTime;
        if (timer < 0)
        {
            Instantiate(zed, spawner.transform.position, Quaternion.identity);
            timer = 3f;
        }
    }
}
