using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWizardAtack : MonoBehaviour {
    private float shotTimer = 0.0f;
    public GameObject enemyBullet;
    public GameObject bulletSpawn;
    public int bps = 10;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        shotTimer += Time.deltaTime;
        if (shotTimer > bps)
        {
            Instantiate(enemyBullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
            shotTimer = 0;
        }
    }
}
