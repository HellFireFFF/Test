using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCConversation : MonoBehaviour
{
    public DialogManager dialogManager;
    public LookMouse lookMouse_thirdPerson;
    public LookMouse lookMouse_firstPerson;
    public Dialog diag;

    public void Start()
    {
        dialogManager = GameObject.Find("Dialog").GetComponent<DialogManager>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            //look at player
            transform.LookAt(other.transform, Vector3.up);

            //Start Dialog
            dialogManager.StartDialog(diag);
            lookMouse_thirdPerson.enabled = false;
            lookMouse_firstPerson.enabled = false;
            //Don't forget to give the Next and Exit Button some funtionality 
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.transform.tag == "Player")
        {
            dialogManager.StopDialog();

            lookMouse_firstPerson.enabled = true;
            lookMouse_thirdPerson.enabled = true;
        }
    }
}
