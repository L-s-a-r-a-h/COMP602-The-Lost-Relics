using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class CoinTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void CoinTestSimplePasses()
    {
        CurrentCoins.numCoins = 0;
        
        // Use the Assert class to test conditions
        GameObject obj = new GameObject();
        obj.AddComponent<Coin>();

        Coin coin = obj.GetComponent<Coin>();
        coin.value = 1;

        Debug.Log(CurrentCoins.numCoins);
        Assert.AreEqual(5, CurrentCoins.numCoins);
        coin.coinValue();
        Debug.Log(CurrentCoins.numCoins);
        Assert.AreEqual(1, CurrentCoins.numCoins);

    }

    

}
