using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAtPlayer : MonoBehaviour
{

    public bool isInRange;

    public void OnTriggerStay(Collider other)
    {

        if (other.transform.tag == "Player")
        {
            //look at player
            transform.LookAt(other.transform, Vector3.up);
            isInRange = true;

        }

    }

    public void OnTriggerExit()
    {

        isInRange = false;

    }
}
