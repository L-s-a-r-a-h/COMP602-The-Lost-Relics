using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{


     public enum ItemType
      {
          PotionNone,
          Potion,
          Potion_UpgradeNone,
          Potion_Upgrade,
          KeyNone,
          Key
      }

      //Function to get the cost
      public static int GetCost(ItemType itemType)
      {
          switch (itemType)
          {
              default:
              case ItemType.PotionNone: return 0;
              case ItemType.Potion: return 80;
              case ItemType.Potion_UpgradeNone: return 0;
              case ItemType.Potion_Upgrade: return 400;
              case ItemType.KeyNone: return 0;
              case ItemType.Key: return 300;
          }
      }




    public static Sprite GetSprite(ItemType itemType)
    {
        switch (itemType)
        {
            default:
            case ItemType.PotionNone: return GameAssets.i.PotionNone;
            case ItemType.Potion: return GameAssets.i.Potion;
            case ItemType.Potion_UpgradeNone: return GameAssets.i.PotionUpgradeNone;
            case ItemType.Potion_Upgrade: return GameAssets.i.PotionUpgrade;
            case ItemType.KeyNone: return GameAssets.i.KeyNone;
            case ItemType.Key: return GameAssets.i.Key;
 
        }
    }

}
