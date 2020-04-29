using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAIScript : MonoBehaviour{
    public GameObject target;
    Quaternion lookRotation1;
    Vector3 direction1;
    public float speed;

    void Update(){
        if (target != null){
            direction1 = (target.transform.position - transform.position).normalized;
            lookRotation1 = Quaternion.LookRotation(direction1);

            transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation1, 10f);
        }
    }
}