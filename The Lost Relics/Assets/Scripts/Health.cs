using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    public float currentHealth { get; private set; }

    private void Awake() 
    {
        currentHealth = maxHealth;
    }

    public void DecreaseHealth(float health) 
    {
        currentHealth -= health;
        if (currentHealth > 0)
        {
            // play hurt animation
        }
        else
        {
            // play dead animation, go to dead screen etc.
        }
    }

    public void IncreaseHealth(float health)
    {
        if (currentHealth + health <= maxHealth)
        {
            currentHealth += health;
        }
    }

    // Press 'E' to test damage
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            DecreaseHealth(1);
        }
    }
}
