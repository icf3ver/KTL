using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wall : MonoBehaviour {
    void OnTriggerEnter(Collider other){
        if (!other.CompareTag("Player")){
            Destroy(other.gameObject);
        }
    }
}
