using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class Potion : MonoBehaviour
{
    public static int numberOfPotions;
    public TextMeshProUGUI potionCounterText;
    public KeyCode useKey;

    /*
     * Starts the game with 0 health potions
     */
    public void Awake()
    {
        numberOfPotions = 0;
    }

    // updates the number of potions currently held and changes the counter on the HUD.
    public void Update()
    {
        potionCounterText.text = " : " + numberOfPotions;

        if (HealthPot.numberOfPotions >= 1)
        {
            if (Input.GetKeyDown(useKey))
            {
                Consume();
                numberOfPotions--;
            }
        }
    }

    public abstract void Consume();
}
