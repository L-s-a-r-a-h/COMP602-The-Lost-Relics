using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class GameData
{
    public int coins_balance;
    public float current_health;
    public float relics;
    public serialisableType<string, bool> RelicsCollected;
    public Vector3 playerPosition;
    public string scene;
    public serialisableType<string, bool> coinCollected;

// new GameData when there is no saved games to load
    public GameData()
    {
        // default values 
        playerPosition = Vector3.zero;
        coinCollected =new serialisableType<string, bool>();
        RelicsCollected = new serialisableType<string, bool>();

        this.coins_balance = 0;
        this.current_health = 5;
        this.relics = 0;
        scene = "";

    }


}
