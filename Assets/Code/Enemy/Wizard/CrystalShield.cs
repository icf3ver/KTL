using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrystalShield : MonoBehaviour {
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("shot")) {
            Destroy(other.gameObject);
            Destroy(this.gameObject);
        }
    }
}
