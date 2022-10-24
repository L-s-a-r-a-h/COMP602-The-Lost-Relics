using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField] private float healthValue;
    private bool collected = false;
    [SerializeField] private string id;
    [ContextMenu("Generate guid for id")]


    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //&& Health.IncreaseHealth(healthValue)


            HealthPot.numberOfPotions++;
            collected = true;
            this.gameObject.SetActive(false);
            //  Destroy(GetComponent<Collider2D>().gameObject);
            Debug.Log("HP potion collected");
            
        }
    }
    public void LoadData(GameData data)
    {

        data.coinCollected.TryGetValue(id, out collected);

        if (this.collected)
        {
            gameObject.SetActive(false);
        }


    }

    public void SaveData(ref GameData data)
    {
        if (data.coinCollected.ContainsKey(id))
        {
            data.coinCollected.Remove(id);
        }
        data.coinCollected.Add(id, collected);
    }
}
