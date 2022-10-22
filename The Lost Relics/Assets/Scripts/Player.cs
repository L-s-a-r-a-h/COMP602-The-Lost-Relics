

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Player : MonoBehaviour, IShopCustomer
{

    public static Player Instance { get; private set; }

    public event EventHandler OnGoldAmountChanged;
    

    private int goldAmount = 1000;
    private int healthPotionAmount;


  

  

   
    public void AddGoldAmount(int addGoldAmount)
    {
        goldAmount += addGoldAmount;
        OnGoldAmountChanged?.Invoke(this, EventArgs.Empty);
    }

    public int GetGoldAmount()
    {
        return goldAmount;
    }

    public void BoughtItem(Item.ItemType itemType)
    {
        Debug.Log("Bought item: " + itemType);
        switch (itemType)
        {
            case Item.ItemType.Potion: Debug.Log("Bought potion"); break;
            case Item.ItemType.Potion_Upgrade: Debug.Log("Bought potion Upgrade"); break;
            case Item.ItemType.Key: Debug.Log("Bought Key"); break;
          
        }
    }

    public bool TrySpendGoldAmount(int spendGoldAmount)
    {
        if (GetGoldAmount() >= spendGoldAmount)
        {
            goldAmount -= spendGoldAmount;
            OnGoldAmountChanged?.Invoke(this, EventArgs.Empty);
            return true;
        }
        else
        {
            return false;
        }
    }

}