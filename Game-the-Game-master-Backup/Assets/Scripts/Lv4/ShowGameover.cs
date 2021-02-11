using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowGameover : MonoBehaviour
{
    private GameObject player;

    public void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void Update()
    {
        if(player.GetComponent<Stats>().currentHitpoints == 0)
        {
            gameObject.SetActive(true);
        }
    }
}
