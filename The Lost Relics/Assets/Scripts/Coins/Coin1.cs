using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin1 : MonoBehaviour, IDataPercistence
{
    public int value;
    public float projectileSpeed = 3;
    private Rigidbody2D rigidody;
    private bool collected = false;
    private SpriteRenderer visual;
    [SerializeField] private string id;
    [ContextMenu("Generate guid for id")]
   

    private void GenerateGuid()
    {
        id=System.Guid.NewGuid().ToString();   
    }

    void Start()
    {
        visual = this.GetComponentInChildren<SpriteRenderer>();

        rigidody = GetComponent<Rigidbody2D>();
        rigidody.velocity = transform.right * projectileSpeed;
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the player collides with the coin, its added to there invintory
        //the coin will be destroyed in the scene so it can only be collected once.

        if(collision.transform.tag == "Player")
        {

            if (!collected)
            {
                CollectCoin();
            }
           
         //   Destroy(GetComponent<Collider2D>().gameObject);
        
        }
    }

    private void CollectCoin()
    {
        collected = true;
        visual.gameObject.SetActive(false);
        CurrentCoins.numCoins = (CurrentCoins.numCoins + value);
    }
    public void LoadData(GameData data)
    {
     
            data.coinCollected.TryGetValue(id, out collected);

            if (this.collected)
            {
            gameObject.SetActive(false);
            }
    
     
    }

    public void SaveData(ref GameData data)
    {
        if(data.coinCollected.ContainsKey(id))
        {
            data.coinCollected.Remove(id);
        }
        data.coinCollected.Add(id, collected);
    }
}
