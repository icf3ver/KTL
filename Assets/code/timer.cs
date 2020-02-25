using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour {
    //public Health scripting;
    public Text timeing;
    float seconds = 0;
    float secf = 0;
    float minf = 0;
    bool freeze;
    public GameObject Boss_spawn_position;
    public GameObject Boss1;
    public GameObject Boss2;
    public GameObject Boss3;
    public GameObject Boss4;
    int loop1 = 0;
    int loop2 = 0;
    int loop3 = 0;
    int loop4 = 0;
    // Use this for initialization
    void Start () {
        timeing.text = "0:00";
        freeze = false;
    }

    public void Kill()
    {
        freeze = true;
    }
	
	// Update is called once per frame
	void Update () {
        if(freeze == false)
        {
            seconds += Time.deltaTime;
            secf = Mathf.Floor(seconds % 60);
            minf = Mathf.Floor(seconds / 60);
            timeing.text = String.Format("{0:00}:{1:00}", minf, secf);
            if(minf == 1 && loop1 == 0)
            {
                Instantiate(Boss1, Boss_spawn_position.transform.position, Boss_spawn_position.transform.rotation);
                loop1 = 1;
            }else if(minf == 10 && loop2 == 0)
            {
                Instantiate(Boss2, Boss_spawn_position.transform.position, Boss_spawn_position.transform.rotation);
                loop2 = 1;
            }
        }
        
    }

}
