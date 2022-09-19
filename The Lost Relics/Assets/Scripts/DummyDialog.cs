using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using TMPro;

public class DummyDialog : Interactable
{
    [SerializeField] private TextMeshPro message;
    public static bool shoot = false;

    private void Awake()
    {
        message.enabled = false;
    }

    public override void Interact()
    {
        shoot = true;
        message.enabled = true;
        Debug.Log("Interacted");
    }

    public override void HideInteraction()
    {
        shoot = false;
        message.enabled = false;
    }
}