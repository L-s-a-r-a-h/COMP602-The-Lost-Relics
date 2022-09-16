using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class GameData
{
    public int coins_balance;
    public int health;
    public int relics;
    public Vector3 playerPosition;
    public Dictionary<string, bool> coinsCollected;
    public Dictionary <string,bool> relicsCollected;


// new GameData when there is no saved games to load
    public GameData()
    {
        // default values 

   
        playerPosition = Vector3.zero;
        this.coins_balance = 0;
        this.health = 10;
        coinsCollected = new Dictionary<string, bool>();
        relicsCollected = new Dictionary<string, bool>();

    }


}
