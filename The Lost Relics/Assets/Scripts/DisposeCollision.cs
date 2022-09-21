using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisposeCollision : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //If an item collides with a hazard the item is then destroyed
        if (collision.tag == "Hazard")
        {
            Destroy(GetComponent<Collider2D>().gameObject);
            Debug.Log("Item destroyed");
        }
    }
}
