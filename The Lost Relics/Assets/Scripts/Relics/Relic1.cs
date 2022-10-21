using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Relic1 : MonoBehaviour, IDataPercistence
{

    private bool collected = false;
    private SpriteRenderer visual;
    [SerializeField] private string id;
    [ContextMenu("Generate guid for id")]


    void Start()
    {
        visual = this.GetComponentInChildren<SpriteRenderer>();

    }

    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //When the player collides with the relic, its added to there invintory
        //the relic will be destroyed in the scene so it can only be collected once.

        if (collision.transform.tag == "Player")
        {
            if (!collected)
            {
                CollectRelic();
            }

        
          //  Destroy(GetComponent<Collider2D>().gameObject);
            Debug.Log("Relic Collected");
          
        }
    }

    private void CollectRelic()
    {
        collected = true;
        visual.gameObject.SetActive(false);
        RelicsCollected.numRelics++;
        returnManager.instance.RelicCollected();
    }

    public void LoadData(GameData data)
    {

        data.RelicsCollected.TryGetValue(id, out collected);
        Debug.Log("id " + id + "collected " + collected);
        if (this.collected)
        {
            gameObject.SetActive(false);
        }


    }

    public void SaveData(ref GameData data)
    {
        if (data.RelicsCollected.ContainsKey(id))
        {
            data.RelicsCollected.Remove(id);
        }
        data.RelicsCollected.Add(id, collected);
    }
}
