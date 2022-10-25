using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value;
    public float projectileSpeed = 3;
    private Rigidbody2D rigidody;

    void Start()
    {
        rigidody = GetComponent<Rigidbody2D>();
        rigidody.velocity = transform.right * projectileSpeed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the player collides with the coin, its added to there invintory
        //the coin will be destroyed in the scene so it can only be collected once.

        if(collision.transform.tag == "Player")
        {
            collect();
        }
    }

    public void coinValue()
    {
        CurrentCoins.numCoins = (CurrentCoins.numCoins + value);
    }
    
    public void collect()
    {
        coinValue();
        Destroy(GetComponent<Collider2D>().gameObject);
        Debug.Log(CurrentCoins.numCoins);
    }


}
