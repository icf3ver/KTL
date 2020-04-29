using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotMove : MonoBehaviour {
    public int kills;

    void Update(){
        transform.Translate(Vector3.forward * 20 * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("zombie")){
            Destroy(other.gameObject);
            kills = kills + 1;
            Destroy(this.gameObject);
        }else if (other.gameObject.CompareTag("wizard")){
            Destroy(other.gameObject);
            kills = kills + 1;
            Destroy(this.gameObject);
        }else if (other.gameObject.CompareTag("runner")){
            Destroy(other.gameObject);
            kills = kills + 1;
            Destroy(this.gameObject);
        }else if (other.gameObject.CompareTag("bomber")){
            Destroy(other.gameObject);
            kills = kills + 1;
            Destroy(this.gameObject);
        }else if (other.gameObject.CompareTag("crystalProjectile")){
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }else if (!other.gameObject.CompareTag("proximity")){
            Destroy(this.gameObject);
        }
    }
}
