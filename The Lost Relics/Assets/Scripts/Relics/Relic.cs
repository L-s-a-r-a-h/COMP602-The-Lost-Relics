using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the player collides with the relic, its added to there invintory
        //the relic will be destroyed in the scene so it can only be collected once.

        if (collision.transform.tag == "Player")
        {
            RelicsCollected.numRelics++;
            Destroy(GetComponent<Collider2D>().gameObject);
            Debug.Log("Relic Collected");
            returnManager.instance.RelicCollected();
        }
    }
}
