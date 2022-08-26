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
        // TO DO LATER
        return null;
    }


    public void Save(GameData data)
    {
        // get the path of the save file
        // maybe does not work for mac if i use dataDirPath + "/" + dataFileName;

        string fullPath = Path.Combine(dataDirPath, dataFileName);



        try
        {
            //create directory path if does not exist
            Directory.CreateDirectory(Path.GetDirectoryName(fullPath));

            // game data into json file


        }
        catch(Exception e)
        {
            Debug.LogError("Game save error - cannot get path name? " + fullPath+ "\n"+ e);
        }
        
    }
}
