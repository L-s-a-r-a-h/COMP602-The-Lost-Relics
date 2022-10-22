using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public Dialogue dialogue;
    public bool playerIsClose;
    DialogueManager manager;
    public int startTalking = 0;

    /*public void TriggerDialogue()
{
FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
}*/
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && playerIsClose)
        {
            if(startTalking == 0)
            {
                FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
                startTalking = 1;
            }
           
            //trying press e to continue talk
            if (Input.GetKeyDown(KeyCode.E))
            {
                FindObjectOfType<DialogueManager>().DisplayNextSentence();
            }

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
            startTalking = 0;

        }

    }
}
