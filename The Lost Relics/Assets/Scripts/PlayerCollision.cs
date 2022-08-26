using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollision : MonoBehaviour
{

    private int coins = 0;
   

    private void OnTriggerEnter2D(Collider2D collider2D)
    {
        if (collider2D.gameObject.CompareTag("Coin"))
        {
            coins++;
            Destroy(collider2D.gameObject);
            Debug.Log(" " + coins);
        }
    }
}
