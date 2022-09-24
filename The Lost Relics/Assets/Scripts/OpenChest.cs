using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : Interactable
{

    private Animator anim;
    public Transform startPos;
    public GameObject coin;
    bool opened = false;
   

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
    }

    public override void Interact()
    {
     
        if (opened == false)
        {
            anim.enabled = true;
            anim.Play("AM Chest Wooden - Open");
            Instantiate(coin, startPos.position, startPos.rotation);
            Debug.Log("Opened");
            opened = true;
        }
    }

    

    public override void HideInteraction()
    {
       
    }
}
