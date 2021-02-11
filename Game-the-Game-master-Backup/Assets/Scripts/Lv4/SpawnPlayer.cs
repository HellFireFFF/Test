using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public GameObject player;
    public GameObject respawn;

    private Vector3 respawnPoint;

    public void Start()
    {
        respawnPoint = respawn.gameObject.transform.position;
        //player = GameObject.FindGameObjectWithTag("Player");
    }

    public void OnTriggerEnter(Collider bounds)
    {
        if(bounds.gameObject == player.gameObject)
        {
            Debug.Log("hit");
            player.transform.position = respawnPoint;
        }
    }
}
