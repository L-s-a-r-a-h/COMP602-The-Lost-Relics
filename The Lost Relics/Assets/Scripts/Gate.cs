using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gate : Interactable
{

    public UnityEvent customEvent;

     public override void Interact()
    {
      customEvent.Invoke();
    }

    public override void HideInteraction()
    {
      
    }

      
}
