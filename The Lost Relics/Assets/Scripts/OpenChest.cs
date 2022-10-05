using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenChest : Interactable
{

    private Animator anim;
    public Transform startPos;
    public GameObject item;
    public bool locked;

   

    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;

    }

    public override void Interact()
    {
     
                   if (locked == true)
            {
                anim.enabled = true;
                anim.Play("AM Chest Golden - Open");
                Instantiate(item, startPos.position, startPos.rotation);
                Debug.Log("Opened");
            }
            else
            {
                anim.enabled = true;
                anim.Play("AM Chest Wooden - Open");
                Instantiate(item, startPos.position, startPos.rotation);
                Debug.Log("Opened");
            }
        
    }

    public override void HideInteraction()
    {
       
    }
}
