using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RelicsCollected : MonoBehaviour
{
    public static int numRelics;
    public TextMeshProUGUI relicText;

    // start game with 0 coins
    //will update once load function is ready
    private void Awake()
    {
        numRelics = 0;
    }

    // keeps track of the amount of coins collected and updates the hud.
    void Update()
    {
        relicText.text = "Relics: " + numRelics;
    }
}
