using UnityEngine;

public class HealthPotion : MonoBehaviour,IDataPercistence
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
        if (collision.gameObject.name == "Player" && Health.IncreaseHealth(healthValue))
        {
            gameObject.SetActive(false);
            this.collected = true;
        }
    }
    public void LoadData(GameData data)
    {

        data.HealthCollected.TryGetValue(id, out collected);

        if (this.collected)
        {
            gameObject.SetActive(false);
        }


    }

    public void SaveData(ref GameData data)
    {
        if (data.HealthCollected.ContainsKey(id))
        {
            data.HealthCollected.Remove(id);
        }
        data.HealthCollected.Add(id, collected);
    }
}
