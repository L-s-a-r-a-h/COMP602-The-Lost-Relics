using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooter : MonoBehaviour
{

    public Transform startPos;
    public GameObject projectile;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Instantiate(projectile, startPos.position, startPos.rotation);
        
        }
    }     
}
