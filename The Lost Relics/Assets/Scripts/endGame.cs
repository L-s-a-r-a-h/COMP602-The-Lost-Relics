using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endGame : MonoBehaviour
{
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.transform.tag == "Player" && RelicsCollected.numRelics == 5)
        {
            endGameCredit();
        }
    }

    //add endgame credit
    public void endGameCredit()
    {
        Debug.Log("Roll end credit...");
    }
}
