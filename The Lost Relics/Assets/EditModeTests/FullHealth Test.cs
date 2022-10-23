using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class FullHealthTest
{

    // Tests Full Health Interact
    [Test]
    public void FullHealthInteract()
    {
        Health.MaxHealth = 5f;
        Health.CurrentHealth = 3f;

        Assert.AreNotEqual(Health.MaxHealth, Health.CurrentHealth);
        Debug.Log("max health = " + Health.MaxHealth + ", current health = " + Health.CurrentHealth + ", max health != current health");

        GameObject obj = new GameObject();
        obj.AddComponent<FullHealth>();
        FullHealth fullHealth = obj.GetComponent<FullHealth>();

        fullHealth.Interact();

        Assert.AreEqual(Health.MaxHealth, Health.CurrentHealth);
        Debug.Log("max health = " + Health.MaxHealth + ", current health = " + Health.CurrentHealth + ", max health == current health");
    }
}
