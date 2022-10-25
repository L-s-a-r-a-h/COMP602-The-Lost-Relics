using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxUpPotion : MonoBehaviour
{
    
    private bool collected = false;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            MaxUpgrade.numberOfMaxPotions++;
            collected = true;
            this.gameObject.SetActive(false);
          
            Debug.Log("Max potion collected");
            
        }
    }
}
