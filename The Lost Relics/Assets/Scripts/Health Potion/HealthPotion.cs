using UnityEngine;

public class HealthPotion : MonoBehaviour
{
    [SerializeField] private float healthValue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //&& Health.IncreaseHealth(healthValue)


            HealthPot.numberOfPotions++;
            Destroy(GetComponent<Collider2D>().gameObject);
            Debug.Log("HP potion collected");
            
        }
    }
}
