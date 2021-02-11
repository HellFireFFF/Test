using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationChest : MonoBehaviour
{
    bool isOpen = false;
    bool isInteractable;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && isInteractable)
        {
            StartCoroutine("OpenBox");
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            isInteractable = true;
            Debug.Log("InsideTheTrigger");
        }
        else
        {
            isInteractable = false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        isInteractable = false;
    }

    IEnumerator OpenBox()
    {
        if (!isOpen)
        {
            GetComponent<Animator>().SetTrigger("openChest");
            isOpen = true;
            Debug.Log("Open Chest");

            yield return new WaitForSeconds(2.3f);

            if (transform.GetComponent<ItemDrop>() != null)
            {
                transform.GetComponent<ItemDrop>().DropItems();
            }
        }
    }
}

