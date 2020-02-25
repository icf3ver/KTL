using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour {
    public Boom script;
    public timer code;
    public int healthAmount;
    public int enemyDamage;
    public float damage;
    public Text youLoose;
    public RawImage img;

    bool blind;
    float blindTime;

    // Use this for initialization
    void Start()
    {
        damage = 0;
        blindTime = 1f;
        blind = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (healthAmount == 0)
        {
            youLoose.text = "You Loose! :D";
            Screen.lockCursor = false;
            code.Kill();
            Destroy(gameObject);
            
        }
        if(script.getBoomed == true)
        {
            healthAmount = healthAmount - 10;
            damage = 5.98f;
            
        }
        if (blind)
        {
            Debug.Log("Blinded");
            img.color = new Color(255, 255, 255, blindTime);
            blindTime -= Time.deltaTime;
            if (blindTime < 0)
            {
                blind = false;
                blindTime = 1f;
            }
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            blind = true;
        }

    }
    void OnCollisionEnter(Collision other)
    {
        //Debug.Log("working");
        if (other.gameObject.CompareTag("Zomby"))
        {
            //Debug.Log("worcking");
            healthAmount = healthAmount - enemyDamage;
            damage = 5.98f;

            //damage = 0;
            //need to substract 5.98 from helth x position


        }
        if (other.gameObject.CompareTag("cristalProjectileTag"))
        //if (col.gameObject.name == "cristalProjectile")
        {
            Debug.Log("worcking 1");
            healthAmount = healthAmount - enemyDamage;
            damage = 5.98f;

            //damage = 0;
            //need to substract 5.98 from helth x position


        }
        if (other.gameObject.CompareTag("runner"))
        //if (col.gameObject.name == "cristalProjectile")
        {
            Debug.Log("worcking 1");
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
    public void Fash()
    {
        blind = true;
    }

    public void TakeDamage()
    {
        healthAmount = healthAmount - enemyDamage;
        damage = 5.98f;
    }

}
