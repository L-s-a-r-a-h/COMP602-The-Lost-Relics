using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;


public class manager : MonoBehaviour, IDataPercistence
{

    public void LoadData(GameData data)
    {
        //load the saved data
        Debug.Log("Loading game data from game");
        this.transform.position = data.playerPosition;
        CurrentCoins.numCoins = data.coins_balance;
        Health.CurrentHealth = data.current_health;
        RelicsCollected.numRelics = data.relics;
    }

    public void SaveData(ref GameData data)
    {
        //save the data

        data.playerPosition = this.transform.position;
        data.coins_balance = CurrentCoins.numCoins;
        data.relics = RelicsCollected.numRelics;
        data.current_health = Health.CurrentHealth;
        data.scene = SceneManager.GetActiveScene().name;

}


}

