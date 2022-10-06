using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.SceneManagement;


public class manager : MonoBehaviour, IDataPercistence
{
   // public static manager instance;
    /*void Awake()
    {
        if (instance != null && instance != this)
            Destroy(this.gameObject);
        else
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }*/


    public void LoadData(GameData data)
    {
        //load the saved data
        Debug.Log("Loading game data from game");
        Debug.Log("loading position");
       // SceneManager.LoadSceneAsync(data.scene);
        this.transform.position = data.playerPosition;

        Debug.Log("loading coins balance");
        CurrentCoins.numCoins = data.coins_balance;
        Debug.Log(data.coins_balance+ " coins ");
        Health.CurrentHealth = data.current_health;
        Debug.Log("health :  " + data.current_health);

        Debug.Log("LOAD :  " + data.scene);

    }

    public void SaveData(ref GameData data)
    {
        //save the data
        Debug.Log("saving player position");
        data.playerPosition = this.transform.position;
        Debug.Log("saving coin balance ");
        data.coins_balance = CurrentCoins.numCoins;
      //  Debug.Log("saving health " + health.currentHealth);
        data.current_health = Health.CurrentHealth;
        data.scene = SceneManager.GetActiveScene().name;

}


}

