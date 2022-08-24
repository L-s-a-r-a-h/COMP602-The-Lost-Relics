using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerCollision : MonoBehaviour
{

    private int coins = 0;
    public TextMeshProUGUI coinsText;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.CompareTag("Coin"))
        {
            coins++;
            Destroy(collider2D.gameObject);
            coinsText.text = "Coins: " + coins;
            Debug.Log(coins);
        }
    }
}
