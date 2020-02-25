using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour {

    public GameObject Target;
    Quaternion lookRotation1;
    Vector3 direction1;
    public float speed;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction1 = (Target.transform.position - transform.position).normalized;
        lookRotation1 = Quaternion.LookRotation(direction1);

        transform.position = Vector3.MoveTowards(transform.position, Target.transform.position, speed);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation1, 10f);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("shot"))
        {

        }
    }
}
