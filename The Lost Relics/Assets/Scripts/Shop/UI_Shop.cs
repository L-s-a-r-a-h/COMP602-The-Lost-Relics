using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using CodeMonkey.Utils;
public class UI_Shop : MonoBehaviour
{
    private Transform container;
    private Transform shopItemTemplate;
    private IShopCustomer shopCustomer;


    private void Awake()
    {
        container = transform.Find("container");
        shopItemTemplate = container.Find("shopItemTemplate");
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        CreateItemButton(Item.ItemType.Potion, Item.GetSprite(Item.ItemType.Potion), "Potion", Item.GetCost(Item.ItemType.Potion), 0);
        CreateItemButton(Item.ItemType.Potion_Upgrade, Item.GetSprite(Item.ItemType.Potion_Upgrade), "PotionUpgrade", Item.GetCost(Item.ItemType.Potion_Upgrade), 1);
        CreateItemButton(Item.ItemType.Key, Item.GetSprite(Item.ItemType.Key), "Key", Item.GetCost(Item.ItemType.Key), 2);

        Hide();
    }

    private void CreateItemButton(Item.ItemType itemType, Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        shopItemTransform.gameObject.SetActive(true);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 90f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("nameText").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("itemImage").GetComponent<Image>().sprite = itemSprite;

        shopItemTransform.GetComponent<Button_UI>().ClickFunc = () => {
             //Clicked on shop item button
           TryBuyItem(itemType);
        };
    }


    
    private void TryBuyItem(Item.ItemType itemType)
    {
        {
            //shopCustomer.BoughtItem(itemType);


            if (shopCustomer.TrySpendGoldAmount(Item.GetCost(itemType)))
            {
                // Can afford cost
                shopCustomer.BoughtItem(itemType);
            }
            else
            {
                //Tooltip_Warning.ShowTooltip_Static("Cannot afford " + Item.GetCost(itemType) + "!");
                Debug.Log("Cannot afford");
            }
        } 
    }
    
    public void Show(IShopCustomer shopCustomer)
        {
            this.shopCustomer = shopCustomer;
            gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }


}

