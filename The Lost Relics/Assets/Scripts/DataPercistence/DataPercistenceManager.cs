using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class DataPercistenceManager : MonoBehaviour
{

    [Header("File storage config")]

    [SerializeField] private string fileName;

    private GameData gameData;
    private List<IDataPercistence> dataPercistenceObjects;

    public static DataPercistenceManager instance { get; private set; }


    private FileDataHandler dataHandler;


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

        this.dataHandler = new FileDataHandler(Application.persistentDataPath,fileName);
        this.dataPercistenceObjects = FindDataPercistenceObjects();

        loadGame();
        Debug.Log(" game loaded");
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

   //     Debug.Log("coin balance  =  " + gameData.coins_balance);


        dataHandler.Save(gameData);

    }

    public void loadGame()
    {

        this.gameData = dataHandler.Load();

        if (this.gameData == null)
        {
            Debug.Log("no game data found. starting new game");
            newGame();
        }
        foreach (IDataPercistence dataPercistenceObject in dataPercistenceObjects)
        {
            dataPercistenceObject.LoadData(gameData);
        }
        Debug.Log(" hi hi ");
    }


    private List<IDataPercistence> FindDataPercistenceObjects()
    {

        IEnumerable<IDataPercistence> dataPercistenceObjects = FindObjectsOfType<MonoBehaviour>().OfType<IDataPercistence>();


        return new List<IDataPercistence>(dataPercistenceObjects);
    }


   /* private void OnApplicationQuit()
    {
        saveGame();
    }*/

    public void ButtonSave()
    {
        saveGame();
    }


}
