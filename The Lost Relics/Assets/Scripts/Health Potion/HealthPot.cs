using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthPot : MonoBehaviour
{
    public static int numberOfPotions;
    public TextMeshProUGUI potionCounterText;

    /*
     * Starts the game with 0 health potions
     */
    private void Awake()
    {
        numberOfPotions = 0;
    }

    // updates the number of potions currently held and changes the counter on the HUD.
    void Update()
    {
        potionCounterText.text = " : " + numberOfPotions;
    }
}
