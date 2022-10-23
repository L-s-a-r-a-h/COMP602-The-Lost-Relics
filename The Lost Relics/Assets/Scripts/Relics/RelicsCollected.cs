using UnityEngine;
using UnityEngine.UI;

public class RelicsCollected : MonoBehaviour
{
    public static int numRelics;
    [SerializeField] private Image currentRelics;

    // start game with 0 coins
    //will update once load function is ready
    private void Awake()
    {
        currentRelics.fillAmount = numRelics / 10;
        numRelics = 0;
    }

    // keeps track of the amount of coins collected and updates the hud.
    void Update()
    {
        currentRelics.fillAmount = numRelics / 10;
    }
}
