using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAssets : MonoBehaviour
{
    private static GameAssets _i;

    public static GameAssets i
    {
        get
        {
            if (_i == null) _i = Instantiate(Resources.Load<GameAssets>("GameAssets"));
            return _i;
        }
    }

    public Sprite PotionNone;
    public Sprite Potion;
    public Sprite PotionUpgradeNone;
    public Sprite PotionUpgrade;
    public Sprite KeyNone;
    public Sprite Key;
    

}
