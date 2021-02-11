using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{

    protected int counter = 0;
    public float arrowPower;

    protected bool isTriggered = false;

    public GameObject arrow;

    protected GameObject player;

    protected GameObject me;

    bool isInRange;

    public void Start()
    {

        me = transform.parent.gameObject;

        player = GameObject.FindGameObjectWithTag("Player");

    }

    void FixedUpdate()
    {
      
       
       if (me.GetComponent<EnemyLookAtPlayer>().isInRange)
       {
        
           counter++;
       
       }
       
       if (counter >= 150)
       {
       
           Shoot();
           counter = 0;
       
       }

    }

    public void Shoot()
    {

        var duplicatedArrow = Instantiate(arrow);
        duplicatedArrow.transform.GetComponent<ArrowNew>().parentTrans = transform;
        duplicatedArrow.transform.position = this.transform.position;
        //duplicatedArrow.transform.forward += transform.forward * 1f;
        //duplicatedArrow.transform.rotation = Quaternion.LookRotation(transform.forward, Vector3.up);
        duplicatedArrow.transform.GetComponent<ArrowNew>().SetProjectilePower(arrowPower);
        duplicatedArrow.transform.GetComponent<ArrowNew>().Fire(player.transform.position + Vector3.up);





    }

    

}
