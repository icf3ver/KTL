using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class health : MonoBehaviour {
    public int healthAmount;
    public int enemyDamage;
    public float damage;
	// Use this for initialization
	void Start () {
        damage = 0;
	}
	
	// Update is called once per frame
	void Update () {
		if(healthAmount == 0)
        {
            Destroy(gameObject);
        }
	}
    void OnCollisionEnter(Collision col)
    {
        Debug.Log("working");
        if (col.gameObject.CompareTag("Zomby"))
        {
            Debug.Log("worcking");
            healthAmount = healthAmount - enemyDamage;
            damage = 5.98f;

            //damage = 0;
            //need to substract 5.98 from helth x position


        }

    }
    void OnCollisionExit(Collision col)
    {
        //Debug.Log("working");
        if (col.gameObject.CompareTag("Zomby"))
        {
            damage = 0;
            //need to substract 5.98 from helth x position


        }

    }
}
