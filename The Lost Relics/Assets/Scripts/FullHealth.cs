using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FullHealth : Interactable
{
    

    public override void Interact()
    {
        Health.CurrentHealth = Health.MaxHealth;
        Debug.Log("Interacted with healer");
    }

    public override void HideInteraction()
    {
       
    }
}
