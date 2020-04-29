using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    //public Health scripting;
    public Text timeing;
    float seconds = 0;
    float secf = 0;
    float minf = 0;
    bool freeze;
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
        }
        
    }

}
