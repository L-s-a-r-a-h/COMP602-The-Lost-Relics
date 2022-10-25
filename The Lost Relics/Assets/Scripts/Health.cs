using UnityEngine;

public class Health : MonoBehaviour
{
    public static float MaxHealth;
    public static float CurrentHealth;
    public static bool Hurt;
    public static bool Dead;

    private void Awake() 
    {
        //MaxHealth = 5;
        CurrentHealth = MaxHealth;
        Hurt = false;
        Dead = false;
    }
    public static void DecreaseHealth(float health)
    {
        CurrentHealth -= health;
        Debug.Log("Took " + health + " damage");
        Debug.Log("Current Health: " + CurrentHealth);

        if (CurrentHealth > 0)
        {
            // play hurt animation
            Hurt = true;
        }
        else
        {
            // play dead animation, go to dead screen etc.
            Dead = true;
            Debug.Log("Dead");
        }
    }
    // returns true if increased health
    // returns false if player has maximum health already
    public static bool IncreaseHealth(float health)
    {
        if (CurrentHealth + health <= MaxHealth)
        {
            CurrentHealth += health;
            Debug.Log("Increased " + health + " health");
            Debug.Log("Current Health: " + CurrentHealth);
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
