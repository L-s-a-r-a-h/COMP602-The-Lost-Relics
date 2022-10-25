using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class endGame : MonoBehaviour
{

    public UnityEvent customEvent;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.transform.tag == "Player" && RelicsCollected.numRelics == 0)
        {
            endGameCredit();
        }
    }

    //add endgame credit
    public void endGameCredit()
    {
        customEvent.Invoke();
        Debug.Log("Roll end credit...");
    }
}
