using System;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    private bool playerInRange;
    private bool interacting;

    private void Awake()
    {
        playerInRange = false;
        interacting = false;
    }

    // Update is called once per frame
    private void Update()
    {
        if (!playerInRange)
        {
            if (interacting == true)
            {
                interacting = false;
                HideInteraction();
            }
            return;
        }

        // checks if the player can interact with the interactable object..

        if (Input.GetKeyDown(KeyCode.E))
        {
            if (interacting == false)
            {
                interacting = true;
                Interact();
            }
            else
            {
                interacting = false;
                HideInteraction();
            }
        }
    }

    public abstract void Interact();

    public abstract void HideInteraction();

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            playerInRange = false;
        }
    }
}
