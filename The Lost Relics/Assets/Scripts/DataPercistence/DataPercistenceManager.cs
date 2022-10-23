using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class DataPercistenceManager : MonoBehaviour
{

    [Header("File storage config")]

    // [SerializeField] private string fileName;
    private string fileName = "gameData";

    private GameData gameData;
    private List<IDataPercistence> dataPercistenceObjects;

    public static DataPercistenceManager instance { get; private set; }


    private FileDataHandler dataHandler;


    private void Awake()
    {
        dataPercistenceObjects = new List<IDataPercistence>();
        gameData = new GameData();

        Debug.Log("awake");
        if (instance != null && instance != this)
        {
           
            Debug.Log("error: more than one DataPercistenceManager in Scene");
            Destroy(gameObject);
            Debug.Log("1");
            return;
        }
    
            Debug.Log("2");
            instance = this;
            DontDestroyOnLoad(this.gameObject);
            Debug.Log("3");


        this.dataHandler = new FileDataHandler(Application.persistentDataPath, fileName);

    }
    
    void OnEnable()
    {
        Debug.Log("OnEnable called");
        UnityEngine.SceneManagement.SceneManager.sceneLoaded += OnSceneLoaded;
        Debug.Log("scenemanager.sceneloaded called");
    }

     void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        this.dataPercistenceObjects = FindDataPercistenceObjects();

        Debug.Log("start");
        loadGame();
        Debug.Log("onscene loaded");
   
    }

  
    void OnDisable()
    {
        Debug.Log("OnDisable");
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }
    


    public void newGame()
    {
        this.gameData = new GameData();
        gameData.scene = "Tutorial";
        saveGame();
    }

    public void saveGame()
    {
        foreach (IDataPercistence dataPercistenceObject in dataPercistenceObjects)
        {
            dataPercistenceObject.SaveData(ref gameData);
        }
        dataHandler.Save(gameData);

    }

    private void loadData()
    {
        this.gameData = dataHandler.Load();
        if (this.gameData == null)
        {
            Debug.Log("no game data found. starting new game");
          //  newGame();
            return;
        }
    }
    public void loadGame()
    {
        this.loadData();

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

    public string getSceneName()
    {
        return gameData.scene;
    }

    public void ButtonSave()
    {

        saveGame();
    }


    public void ButtonLoad()
    {
     
        loadGame();
    }

    public void nextScene(string name)
    {

        gameData.scene = name;
        Debug.Log(name);
        saveGame();
        Debug.Log(gameData.scene);
    }



    public void ButtonLoad2()
    {
        SceneManager.LoadScene(gameData.scene);
       // loadGame();
    }


}
