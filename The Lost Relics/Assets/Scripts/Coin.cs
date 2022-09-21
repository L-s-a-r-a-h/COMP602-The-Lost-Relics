using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the player collides with the coin, its added to there invintory
        //the coin will be destroyed in the scene so it can only be collected once.

        if(collision.transform.tag == "Player")
        {
            CurrentCoins.numCoins++;
            Destroy(GetComponent<Collider2D>().gameObject);
            Debug.Log(CurrentCoins.numCoins);
        }
    }

}
