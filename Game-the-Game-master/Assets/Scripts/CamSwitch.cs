using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSwitch : MonoBehaviour
{

    public GameObject firstPersonCam;
    public GameObject thirdPersonCam;

    protected bool thirdPerson = true;

    public void Start()
    {

        thirdPersonCam.SetActive(true);
        firstPersonCam.SetActive(false);

    }

    public void FixedUpdate()
    {

        CameraSwitch();

    }

    public void CameraSwitch()
    {

        if(Input.GetKeyDown(KeyCode.X) && thirdPerson == true)
        {

            thirdPersonCam.SetActive(false);
            firstPersonCam.SetActive(true);
            thirdPerson = false;

        }
        else if(Input.GetKeyDown(KeyCode.X) && thirdPerson == false)
        {

            thirdPersonCam.SetActive(true);
            firstPersonCam.SetActive(false);
            thirdPerson = true;

        }

    }

}
