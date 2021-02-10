using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAtPlayer : MonoBehaviour
{

    protected int counter = 0;

    public GameObject target;

    public bool isInRange;

    void FixedUpdate()
    {

        counter++;

    }

    public void OnTriggerStay(Collider other)
    {

        
        if (other.transform.tag == "Player")
        {
            isInRange = true;
            target = other.gameObject;
            //look at player
            transform.LookAt(other.transform, Vector3.up);

        }

    }

    public void OnTriggerExit(Collider other)
    {

        if (other.transform.tag == "Player")
        {

            isInRange = false;

        }

    }

}
