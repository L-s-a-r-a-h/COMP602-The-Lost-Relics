using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPercistenceManager : MonoBehaviour
{

    private GameData gameData;
    private List<IDataPercistence> dataPercistenceObjects;

    public static DataPercistenceManager instance { get; private set; }


    private void Awake()
    {
        if (instance != null)
        {
            Debug.LogError("error: more than one DataPercistenceManager in Scene");
        }
        instance = this;

    }

    private void Start()
    {
        this.dataPercistenceObjects = FindDataPercistenceObjects();
        loadGame();
    }

    public void newGame()
    {
        this.gameData = new GameData();
    }

    public void saveGame()
    {
        foreach (IDataPercistence dataPercistenceOjbject in dataPercistenceObjects)
        {
            dataPercistenceOjbject.SaveData(ref gameData);
        }

        Debug.Log("coin balance  =  " + gameData.coins_balance);
    }

    public void loadGame()
    {
        //DO LATER
        // 
    }


    private List<IDataPercistence> FindDataPercistenceObjects()
    {

        IEnumerable<IDataPercistence> dataPercistenceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPercistence>();


        return new List<IDataPercistence>(dataPercistenceObjects);
    }

}
