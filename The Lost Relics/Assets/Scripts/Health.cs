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
        Debug.Log("Took " + health + " damage");
        Debug.Log("Current Health: " + currentHealth);

        if (currentHealth > 0)
        {
            // play hurt animation
        }
        else
        {
            // play dead animation, go to dead screen etc.
            Debug.Log("Dead");
        }
    }

    // returns true if increased health
    // returns false if player has maximum health already
    public bool IncreaseHealth(float health)
    {
        if (currentHealth + health <= maxHealth)
        {
            currentHealth += health;
            Debug.Log("Increased " + health + " health");
            Debug.Log("Current Health: " + currentHealth);
            return true;
        }

        return false;
    }

    // Press 'F' to test damage
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            DecreaseHealth(1);
        }
    }
}
