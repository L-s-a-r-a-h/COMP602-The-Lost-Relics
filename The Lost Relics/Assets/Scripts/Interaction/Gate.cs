using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Gate : Interactable
{

    public UnityEvent customEvent;
    public static bool payed = false;

     public override void Interact()
    {
      if(CurrentCoins.numCoins >= 50 && payed == false){
        CurrentCoins.numCoins = CurrentCoins.numCoins - 50;
        payed = true;
      }
      if (payed == true){
      customEvent.Invoke();
      }
    }

    public override void HideInteraction()
    {
      
    }

      
}
