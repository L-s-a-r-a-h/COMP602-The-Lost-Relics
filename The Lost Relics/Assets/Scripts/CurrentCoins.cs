using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CurrentCoins : MonoBehaviour
{ 

    public static int numCoins;
    public TextMeshProUGUI coinsText;

  
    private void Awake()
    {
        numCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
                coinsText.text = "Coins: " + numCoins;
    }

}
