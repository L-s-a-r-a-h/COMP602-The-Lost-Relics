using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image totalHealth;
    [SerializeField] private Image currentHealth;

    private void Start()
    {
        totalHealth.fillAmount = Health.CurrentHealth / 10;
    }

    private void Update()
    {
        currentHealth.fillAmount = Health.CurrentHealth / 10;
        totalHealth.fillAmount = Health.MaxHealth / 10;

    }
}
