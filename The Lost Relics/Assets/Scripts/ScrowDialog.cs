using UnityEngine;
using TMPro;

public class ScrowDialog : Interactable
{
    [SerializeField] private TextMeshPro message;

    private void Awake()
    {
        message.enabled = false;
    }

    public override void Interact()
    {
        message.enabled = true;
        Debug.Log("Interacted");
    }

    public override void HideInteraction()
    {
        message.enabled = false;
    }
}