using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public static bool trig = false;

    private void Awake()
    {
        trig = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Item")
        {
            Debug.Log("Triger has been activated");
            trig = true;
        }
    }
}
