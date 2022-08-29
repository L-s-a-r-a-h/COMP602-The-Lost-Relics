using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour, IDataPercistence
{


    public void LoadData(GameData data)
    {
        Debug.Log("loading position");
        this.transform.position = data.playerPosition;
    }

    public void SaveData(ref GameData data)
    {
        Debug.Log("saving player position");
        data.playerPosition = this.transform.position;
    }


}

