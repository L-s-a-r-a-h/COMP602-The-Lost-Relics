using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] private float damage = 1;

    public float projectileSpeed;
    private Rigidbody2D rigidody;
    public bool shoot;

    void Start()
    {
        rigidody = GetComponent<Rigidbody2D>();
        if(shoot == true)
        {
        rigidody.velocity = transform.right * projectileSpeed;
        }
    }

   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Shot");
            Health.DecreaseHealth(damage);
            Destroy(GetComponent<Collider2D>().gameObject);
        }
        if (collision.tag == "Item")
        {
            Destroy(GetComponent<Collider2D>().gameObject);
        }
    }
}
