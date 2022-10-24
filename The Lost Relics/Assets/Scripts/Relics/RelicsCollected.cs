using UnityEngine;
using UnityEngine.UI;

public class RelicsCollected : MonoBehaviour
{
    public static float numRelics;
    [SerializeField] private Image currentRelics;

  
    private void Awake()
    {
        numRelics = 0;
        Debug.Log("Number of relics: "+numRelics);
        currentRelics.fillAmount = numRelics / 10;
       
    }

    void Update()
    {
        Debug.Log("Number of relics: "+numRelics);
        currentRelics.fillAmount = numRelics / 10;
    }
}
