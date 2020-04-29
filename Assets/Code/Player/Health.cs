using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour {
    public Timer timer;
    public float maxHealth;
    public int enemyDamage;
    public Text gameOver;
    public Button respawn;
    public RawImage flash;
    public Slider healthBar;
    
    bool blind;
    float blindTime;
    float health;

    void Start(){
        health = maxHealth;
        blindTime = 1f;
        blind = false;
    }

    void Update(){
        if (health <= 0){
            healthBar.value = 0;
            healthBar.gameObject.SetActive(false);

            respawn.gameObject.SetActive(true);
            gameOver.gameObject.SetActive(true);

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;

            timer.Kill();
            Destroy(this.gameObject);
        }else{
            healthBar.value = (healthBar.maxValue / maxHealth) * health;
        }

        if (blind){
            flash.color = new Color(255, 255, 255, blindTime);
            blindTime -= Time.deltaTime;
            if (blindTime < 0)
            {
                blind = false;
                blindTime = 1f;
            }
        }
    }

    void OnCollisionEnter(Collision other){
        if (other.gameObject.CompareTag("zombie")){
            health = health - enemyDamage;
        }else if (other.gameObject.CompareTag("crystalProjectile")){
            health = health - enemyDamage;
            Destroy(other.gameObject);
        }else if (other.gameObject.CompareTag("runner")){
            health = health - enemyDamage;
        }else if (other.gameObject.CompareTag("wall")){
            health = 0;
        }
    }

    public void boomed(){
        blind = true;
        health = health - enemyDamage * 3;
    }
}
