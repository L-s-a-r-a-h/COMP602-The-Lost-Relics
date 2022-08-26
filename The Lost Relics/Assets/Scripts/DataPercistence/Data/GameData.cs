using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class GameData
{
    public int coins_balance;
    public int health;
    public int location_x;
    public int location_y;
    public int relics;


// new GameData when there is no saved games to load
    public GameData()
    {
        // default values 
        this.coins_balance = 0;
        this.health = 100;
    }
}
