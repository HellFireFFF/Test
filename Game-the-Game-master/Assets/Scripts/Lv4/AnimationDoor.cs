using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDoor : MonoBehaviour
{
    
    bool isOpen;
    bool hasKey = false;
    bool isInteractable;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isInteractable)
        {

        
            if (!isOpen && hasKey)
            {
                GetComponent<Animator>().SetTrigger("Open");
                isOpen = true;
                Debug.Log("Open");
            }
          

        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.tag == "Player")
        {
            Item[] playerInventory = GameObject.Find("Inventory").GetComponent<InventoryUIConnection>().inventory.inventoryItems;

            if (playerInventory != null)
            {
                foreach (Item item in playerInventory)
                {
                    if (item != null)
                    {
                        if (item.GetName().Contains("Key"))
                        {
                            hasKey = true;
                            Debug.Log("HasKey");
                        }
                    }
                  
                }
            }
            Debug.Log(hasKey);
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag=="Player")
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
}
