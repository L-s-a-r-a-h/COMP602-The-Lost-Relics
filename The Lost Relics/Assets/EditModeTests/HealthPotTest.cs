using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class HealthPotTest
{
    [Test]
    public void test()
    {
        Health.MaxHealth = 5f;
        Health.CurrentHealth = 1f;
        HealthPot.numberOfPotions = 1;
        Debug.Log("Current Health " + Health.CurrentHealth);
        Debug.Log("Number of Potions: " + HealthPot.numberOfPotions);


        GameObject obj = new GameObject();
        obj.AddComponent<HealthPot>();
        HealthPot hp = obj.GetComponent<HealthPot>();

        hp.healthPotionUse();

        Assert.AreEqual(2f, Health.CurrentHealth, "Test for Health Potion");
        Assert.AreEqual(0, HealthPot.numberOfPotions, "Test for number of potions");
        Debug.Log("Current Health " + Health.CurrentHealth);
        Debug.Log("Number of Potions: "+HealthPot.numberOfPotions);

    }

    
}
