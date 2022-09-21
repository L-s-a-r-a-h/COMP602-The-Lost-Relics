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
        //At the moment the arrow is triggered by dialog
        //Will update to be a more universal trigger
            if(DummyDialog.shoot == true)
            {
            //Creates a projectile object and fires it from the fireing objects position and angle.
                Instantiate(projectile, startPos.position, startPos.rotation);
                DummyDialog.shoot = false;
            }
    }
}