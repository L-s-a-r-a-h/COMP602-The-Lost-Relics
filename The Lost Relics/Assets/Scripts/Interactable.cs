using UnityEngine;
// This is an abstract class that should be used for objects that the player can interact with in the game world by pressing 'E'.
// Game Objects such as shops or NPCs may have their own scripts that inherits from this class.
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
        // return if player isn't in range
        if (!playerInRange)
        {
            if (interacting == true)
            {
                interacting = false;
                HideInteraction();
            }
            return;
        }

        InputCheck();
    }

    // checks if the player can interact with the interactable object..
    public void InputCheck()
    {
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
