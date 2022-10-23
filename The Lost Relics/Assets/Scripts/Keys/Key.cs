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

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the player collides with the key, its added to there invintory
        //the key will be destroyed in the scene so it can only be collected once.

        if (collision.transform.tag == "Player")
        {

            Keys.numKeys++;
            collected = true;
            gameObject.SetActive(false);
            //    Destroy(GetComponent<Collider2D>().gameObject);
            Debug.Log("Key Collected");
        }
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
