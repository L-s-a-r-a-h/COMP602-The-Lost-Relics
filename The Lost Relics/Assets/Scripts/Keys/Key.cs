using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour, IDataPercistence
{
    [SerializeField] private string id;
    private bool collected = false;
    [ContextMenu("Generate guid for id")]


    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }
 

    public void LoadData(GameData data)
    {

        data.KeysCollected.TryGetValue(id, out collected);

        if (this.collected)
        {
            gameObject.SetActive(false);
        }


    }

    public void SaveData(ref GameData data)
    {
        if (data.KeysCollected.ContainsKey(id))
        {
            data.KeysCollected.Remove(id);
        }
        data.KeysCollected.Add(id, collected);
    }
}
