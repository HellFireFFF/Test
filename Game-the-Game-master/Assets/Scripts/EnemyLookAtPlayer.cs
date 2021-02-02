using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyLookAtPlayer : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {



    }

    public void OnTriggerStay(Collider other)
    {

        if (other.transform.tag == "Player")
        {
            //look at player
            transform.LookAt(other.transform, Vector3.up);
        }

    }
}
