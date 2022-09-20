using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PopUp : MonoBehaviour
{
    [SerializeField] private TextMeshPro message;

    private void Awake()
    {
        message.enabled = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            message.enabled = true;
            Debug.Log("Pop Up Message");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            message.enabled = false;
        }
    }
}