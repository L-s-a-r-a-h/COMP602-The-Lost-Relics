using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FullHealth : Interactable
{
    public override void Interact()
    {
        Health.IncreaseHealth(5);
    }

    public override void HideInteraction()
    {

    }
}
