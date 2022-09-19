using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.transform.tag == "Player")
        {
            CurrentCoins.numCoins++;
            Destroy(GetComponent<Collider2D>().gameObject);
            Debug.Log(CurrentCoins.numCoins);
        }
    }

}
