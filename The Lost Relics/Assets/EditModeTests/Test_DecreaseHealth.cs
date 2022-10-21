using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Test_DecreaseHealth
{
    // A Test behaves as an ordinary method
    [Test]
    public void TestDHfail()
    {
        // Use the Assert class to test conditions
        Assert.AreEqual(0, Health.CurrentHealth, "TEST for DecreaseHealth failed" );
    }

    [Test]
      public void TestDHPass()
    {
        // Use the Assert class to test conditions
        Health.DecreaseHealth(Health.CurrentHealth);
        Assert.AreEqual(0, Health.CurrentHealth, "TEST for DecreaseHelth Passed" );
    }
}