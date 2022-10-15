using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class OpenChest : Interactable
{

    private Animator anim;
    public Transform startPos;
    public GameObject item;
    public bool locked;
    [SerializeField] private TextMeshPro message;

    


    void Start()
    {
        anim = GetComponent<Animator>();
        anim.enabled = false;
        message.enabled = false;

    }

    public override void Interact()
    {
     
            if (locked == true)
            {
                if(Keys.numKeys > 0)
                {
                    Keys.numKeys--;
                    Debug.Log("Opened, key used");
                    anim.enabled = true;
                    anim.Play("AM Chest Golden - Open");
                    Instantiate(item, startPos.position, startPos.rotation);
                    
                }
                else{
                    message.text = "Locked";
                     message.enabled = true;
                }
            }

            if (locked == false)
            {
                anim.enabled = true;
                anim.Play("AM Chest Wooden - Open");
                Instantiate(item, startPos.position, startPos.rotation);
                Debug.Log("Opened");
            }
        
    }

    public override void HideInteraction()
    {
       message.enabled = false;
    }
}
