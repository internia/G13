using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModalView : MonoBehaviour
{
   public Image image;
    public Sprite newImage;
    //public Modal modal;
    public GameObject modals;
    public GameObject keyPrompt;

    public void setupModal()
    {
        //ModalManager.StartConversation(modal);
         modals.SetActive(true);
    }

    void OnTriggerStay2D(Collider2D other)
    {
        keyPrompt.SetActive(true);

        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            image.sprite = newImage;
            Debug.Log("Set active");
            setupModal();
            keyPrompt.SetActive(false);

        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        keyPrompt.SetActive(false);

    }



}
