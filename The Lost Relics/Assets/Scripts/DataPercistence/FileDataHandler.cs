using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;


// to read and write the save data to the players computi
public class FileDataHandler 
{

    private string dataDirPath = "";
    private string dataFileName = "";

    public FileDataHandler(string dataDirPath, string dataFileName )
    {
        this.dataDirPath = dataDirPath;
        this.dataFileName = dataFileName;

    }

    public GameData Load()
    {

        string fullPath = Path.Combine(dataDirPath, dataFileName);
        Debug.Log("load game data path name is " + fullPath);
        GameData loadedData = null;
        if (File.Exists(fullPath))
        {
            try
            {
                // load data from json file
                String dataToLoad = "";
                using (FileStream fs = new FileStream(fullPath, FileMode.Open))
                {
                    using (StreamReader sr = new StreamReader (fs))
                    {
                        dataToLoad = sr.ReadToEnd();
                    }
                }

                //deserialise the loaded data from json to gameData

                loadedData = JsonUtility.FromJson<GameData>(dataToLoad);


            }
            catch(Exception e)
            {
                Debug.LogError("error occured loading game data from " + fullPath + "/n"+ e);
            }
        }

        return loadedData;
  

    }


    public void Save(GameData data)
    {
        // get the path of the save file
        // maybe does not work for mac if i use dataDirPath + "/" + dataFileName;

        string fullPath = Path.Combine(dataDirPath, dataFileName);


        Debug.Log("save game data path name is " + fullPath);

        try
        {
            //create directory path if does not exist
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

   
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath)); 

            // serialise game data into json 
            string dataToStore = JsonUtility.ToJson(data, true);

            // write the data to file
            using (FileStream fs = new FileStream(fullPath, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.Write(dataToStore);

                }
            }



        }
        catch(Exception e)
        {
            Debug.LogError("Game save error - cannot get path name? " + fullPath+ "\n"+ e);
        }
        
    }
}
