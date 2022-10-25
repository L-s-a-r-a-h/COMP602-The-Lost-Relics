using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCollect : MonoBehaviour
{
    private bool collected = false;
  
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        //When the player collides with the key, its added to there invintory
        //the key will be destroyed in the scene so it can only be collected once.

        if (collision.transform.tag == "Player")
        {

            Keys.numKeys++;
            collected = true;
            gameObject.SetActive(false);
            //    Destroy(GetComponent<Collider2D>().gameObject);
            Debug.Log("Key Collected");
        }
    }
}
