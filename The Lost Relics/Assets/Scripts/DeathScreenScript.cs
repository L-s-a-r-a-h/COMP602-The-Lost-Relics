using UnityEngine;

public class DeathScreenScript : MonoBehaviour
{
    [SerializeField] private GameObject deathScreen;
    [SerializeField] public GameObject player;
    private PlayerMovement pm;

    public void Awake()
    {
        this.deathScreen.SetActive(false);
        this.pm = player.GetComponent<PlayerMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health.Dead && pm.DeadAnimDone)
        {
            deathScreen.SetActive(true);
        }
    }
}
