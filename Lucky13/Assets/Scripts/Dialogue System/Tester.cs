using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tester : MonoBehaviour
{
    public Conversation convo;
    public bool dialoguePlayed = false;
    public GameObject keyPrompt;

    public void StartConvo()
    {
        DialogueManager.StartConversation(convo);
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        if (!dialoguePlayed)
        {
            keyPrompt.SetActive(true);
        }

        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            if (!dialoguePlayed)
            {
                StartConvo();
                dialoguePlayed = true;
            }

        }      
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        keyPrompt.SetActive(false);

    }
}
