using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowShooter : MonoBehaviour
{

    public Transform startPos;
    public GameObject projectile;

    // Update is called once per frame
    void Update()
    {
            if(DummyDialog.shoot == true)
            {
            
                Instantiate(projectile, startPos.position, startPos.rotation);
            DummyDialog.shoot = false;
            }
        
    }
}