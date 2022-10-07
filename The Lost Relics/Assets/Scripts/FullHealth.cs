using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FullHealth : Interactable
{
    

    public override void Interact()
    {
        //Debug.Log("Full is: " + full);
        Health.CurrentHealth = Health.MaxHealth;
        Debug.Log("Interacted with healer");
    }

    public override void HideInteraction()
    {
       
    }
}
