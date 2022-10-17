using UnityEngine;

public class DeathScreenScript : MonoBehaviour
{
    private GameObject deathScreen;
    private GameObject player;
    private PlayerMovement pm;

    public void Awake()
    {
        this.deathScreen = GameObject.Find("DeathScreen");
        this.player = GameObject.Find("Player");
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
