using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterConvo : MonoBehaviour
{
    public Conversation convo;

    void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player") && Input.GetKeyDown(KeyCode.E))
        {
            //Tester.startConvo();
            //DialogueManager.StartConversation(convo);
        }
    }
}
