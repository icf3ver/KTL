using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMove : MonoBehaviour {
    public int kills;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * 20 * Time.deltaTime);

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Zomby"))
        {
            Destroy(other.gameObject);
            kills = kills + 1;
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("WizardTag"))
        {
            Destroy(other.gameObject);
            kills = kills + 1;
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("runner"))
        {
            Destroy(other.gameObject);
            kills = kills + 1;
            Destroy(this.gameObject);
        }
        if (other.gameObject.CompareTag("bomber"))
        {
            Destroy(other.gameObject);
            kills = kills + 1;
            Destroy(this.gameObject);
        }
        Destroy(this.gameObject);
    }
}
