using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class GameData
{
    public int coins_balance;
    public float current_health;
    public int relics;
    public Vector3 playerPosition;
    public Dictionary <string,bool> relicsCollected;
    public string scene;


// new GameData when there is no saved games to load
    public GameData()
    {
        // default values 

   
        playerPosition = Vector3.zero;
        this.coins_balance = 0;
        this.current_health = 5;
        relicsCollected = new Dictionary<string, bool>();
        scene = " ";

    }


}
