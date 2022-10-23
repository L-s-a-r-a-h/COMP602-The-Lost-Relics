using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxUpgrade : Potion
{
    public override void Consume()
    {
        Health.MaxHealth++;
    }

}
