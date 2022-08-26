using System.Collections;
using System.Collections.Generic;
using UnityEngine;
<<<<<<< Updated upstream
using TMPro;
=======

>>>>>>> Stashed changes

public class PlayerCollision : MonoBehaviour
{

<<<<<<< Updated upstream
    private int coins = 0;
    public TextMeshProUGUI coinsText;

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.CompareTag("Coin"))
        {
            coins++;
            Destroy(collider2D.gameObject);
            coinsText.text = "Coins: " + coins;
=======
   private int coins = 0;
   

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if(collider2D.gameObject.CompareTag("coin"))
        {
            coins++;
            Destroy(collider2D.gameObject);
>>>>>>> Stashed changes
            Debug.Log(coins);
        }
    }
}
