using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public bool playerIsClose;
    DialogueManager manager;
    PlayerMovement movement;

    /*public void TriggerDialogue()
{
FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
}*/
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {

            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
            movement.allowedToMoved = false;

        }
       

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerIsClose = true;
          
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {          
            playerIsClose = false;       

        }

    }
}
