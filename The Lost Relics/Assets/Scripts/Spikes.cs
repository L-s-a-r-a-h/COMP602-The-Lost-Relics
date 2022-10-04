using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public float projectileSpeed = 3;
    private Rigidbody2D rigidody;
    [SerializeField] private float damage = 1;

    void Start()
    {
        rigidody = GetComponent<Rigidbody2D>();
        rigidody.velocity = transform.right * projectileSpeed;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Spiked");
            Health.DecreaseHealth(damage);
        }
    }
}
