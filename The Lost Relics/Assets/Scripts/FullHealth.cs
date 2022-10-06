using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FullHealth : Interactable
{
    
    //Should be able to restore full health in one go.
    //public float full = (Health.MaxHealth - Health.CurrentHealth);

    //currently only works restoring 1 health at at time
    private float full = 1;

    public override void Interact()
    {
        Debug.Log("Full is: " + full);
        Health.IncreaseHealth(full);
        Debug.Log("Interacted with healer");
    }

    public override void HideInteraction()
    {
       
    }
}
