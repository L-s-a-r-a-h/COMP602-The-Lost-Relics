using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HealthPot : Potion
{
    public override void Consume()
    {
        Health.IncreaseHealth(1);
    }
}
