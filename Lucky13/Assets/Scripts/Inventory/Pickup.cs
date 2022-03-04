using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    private Inventory inventory;
    public GameObject itemButton;
    public GameObject keyPrompt;


    private void Start()
    {
        inventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
    }
    void OnTriggerStay2D(Collider2D other)
    {
        keyPrompt.SetActive(true);

        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.Q))
        {

            for (int i = 0; i < inventory.slots.Length; i++)
            {
                //if slot is not full
                if (inventory.isFull[i] == false)
                {

                    //ITEM ADDED
                    inventory.isFull[i] = true;
                    Instantiate(itemButton, inventory.slots[i].transform, false);
                    Destroy(gameObject);
                    break;
                }
            }
        }
    }


    private void OnTriggerExit2D(Collider2D other)
    {
        keyPrompt.SetActive(false);

    }
}
