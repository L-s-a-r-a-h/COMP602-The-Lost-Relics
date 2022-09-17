using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float damage = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Shot");
            collision.GetComponent<Health>().DecreaseHealth(damage);
            Destroy(GetComponent<Collider2D>().gameObject);
        }
    }
}
