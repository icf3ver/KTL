using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class killCounter : MonoBehaviour
{
    public Text killAmount;
    public ShotMove hit;
    // Use this for initialization
    void Start()
    {
        killAmount.text = "kills: 0 ";

    }

    // Update is called once per frame
    void Update()
    {
        killAmount.text = "kills: " + hit.kills;
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Zomby"))
        {
            //kills = kills + 1;
        }
        if (other.gameObject.CompareTag("WizardTag"))
        {
            //kills = kills + 1;
        }
        if (other.gameObject.CompareTag("runner"))
        {
            //kills = kills + 1;
        }
        if (other.gameObject.CompareTag("bomber"))
        {
            //kills = kills + 1;
        }

    }
}
