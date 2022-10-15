using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentCoins : MonoBehaviour
{ 

    public static int numCoins;
    public TextMeshProUGUI coinsText;

  // start game with 0 coins
  //will update once load function is ready
    private void Awake()
    {
        numCoins = 0;
    }

    // keeps track of the amount of coins collected and updates the hud.
    void Update()
    {
                coinsText.text = " : " + numCoins;
    }
}
