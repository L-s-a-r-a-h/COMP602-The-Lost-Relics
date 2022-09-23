using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathZone : MonoBehaviour
{
    //If the player passes through the DeathZone they will instanlty lose all their health
    // In other worlds they die
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            Health.DecreaseHealth(Health.CurrentHealth);
        }
    }
}
