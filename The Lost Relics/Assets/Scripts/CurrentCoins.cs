using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentCoins : MonoBehaviour
{ 

    public static int numCoins = 0;
    public TextMeshProUGUI coinsText;

  

    // Update is called once per frame
    void Update()
    {
                coinsText.text = "Coins: " + numCoins;
    }
}
