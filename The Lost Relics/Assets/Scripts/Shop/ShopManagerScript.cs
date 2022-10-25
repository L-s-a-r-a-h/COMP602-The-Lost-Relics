using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class ShopManagerScript : MonoBehaviour
{

    public int[,] shopItems = new int[5, 5];
    [SerializeField] public TextMeshProUGUI CoinsTXT;


    void Start()
    {
        CoinsTXT.text = "Coins:" + CurrentCoins.numCoins.ToString();

        //ID's
        shopItems[1, 1] = 1;
        shopItems[1, 2] = 2;
        shopItems[1, 3] = 3;
        shopItems[1, 4] = 4;

        //Price
        shopItems[2, 1] = 10;
        shopItems[2, 2] = 30;
        shopItems[2, 3] = 3;
        shopItems[2, 4] = 40;

        //Quantity
        shopItems[3, 1] = 0;
        shopItems[3, 2] = 0;
        shopItems[3, 3] = 0;
        shopItems[3, 4] = 0;

    }


    public void Buy()
    {
        GameObject ButtonRef = GameObject.FindGameObjectWithTag("Event").GetComponent<EventSystem>().currentSelectedGameObject;



        if (CurrentCoins.numCoins >= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID])
        {
            CurrentCoins.numCoins -= shopItems[2, ButtonRef.GetComponent<ButtonInfo>().ItemID];
            //shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID]++;
            CoinsTXT.text = "Coins" + CurrentCoins.numCoins.ToString();
            //ButtonRef.GetComponent<ButtonInfo>().QuantityTxt.text = shopItems[3, ButtonRef.GetComponent<ButtonInfo>().ItemID].ToString();

            if (shopItems[1, ButtonRef.GetComponent<ButtonInfo>().ItemID] == 3)
            {
                Keys.numKeys++;
            }
            if(shopItems[1, ButtonRef.GetComponent<ButtonInfo>().ItemID] == 1)
            {
                HealthPot.numberOfPotions++;
            }
            if (shopItems[1, ButtonRef.GetComponent<ButtonInfo>().ItemID] == 2)
            {
                MaxUpgrade.numberOfMaxPotions++;
            }
        }


    }
}
