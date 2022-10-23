using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class GameData
{
    public int coins_balance;
    public float current_health;
    public float max_health;
    public int keys_balance; 
    public int relics;
    public string scene;
    public Vector3 playerPosition;
    public serialisableType<string, bool> coinCollected;
    public serialisableType<string, bool> RelicsCollected;
    public serialisableType<string, bool> KeysCollected;
    public serialisableType<string, bool> HealthCollected;
    public serialisableType<string, Vector3> boxMoved;

    // new GameData when there is no saved games to load
    public GameData()
    {
        // default values 
        playerPosition = Vector3.zero;
        coinCollected =new serialisableType<string, bool>();
        RelicsCollected = new serialisableType<string, bool>();
        KeysCollected = new serialisableType<string, bool>();
        this.max_health = 5;
        this.coins_balance = 0;
        this.current_health = 5;
        this.relics = 0;
        scene = "";

    }


}
