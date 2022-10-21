using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keys : MonoBehaviour
{
    public static int numKeys;
    public TextMeshProUGUI keyText;

    // start game with 0 keys
    //will update once load function is ready
    private void Awake()
    {
        numKeys = 0;
    }

    // keeps track of the amount of coins collected and updates the hud.
    void Update()
    {
       keyText.text = " : " + numKeys;
    }
}
