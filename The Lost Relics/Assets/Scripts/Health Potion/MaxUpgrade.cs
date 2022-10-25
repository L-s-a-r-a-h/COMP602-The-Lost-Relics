using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MaxUpgrade : MonoBehaviour
{
    public static int numberOfMaxPotions;
    public TextMeshProUGUI potionCounterText;

    /*
     * Starts the game with 0 potions
     */
    public void Awake()
    {
        numberOfMaxPotions = 0;
    }

    // updates the number of potions currently held and changes the counter on the HUD.
    public void Update()
    {
        potionCounterText.text = " : " + numberOfMaxPotions;

        if (MaxUpgrade.numberOfMaxPotions >= 1)
        {
            if (Input.GetKeyDown(KeyCode.O))
            {
                Consume();
            }
        }
    }

    private void Consume()
    {
       
        if(numberOfMaxPotions > 0)
        {
            if(Health.CurrentHealth <= Health.MaxHealth)
            {
                Health.CurrentHealth = Health.MaxHealth;
                Health.MaxHealth++;
                Health.CurrentHealth++;
                numberOfMaxPotions--;
            }
             
            
        }
        
    }
}
