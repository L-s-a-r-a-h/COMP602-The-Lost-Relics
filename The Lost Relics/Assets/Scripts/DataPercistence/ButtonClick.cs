using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{

public void ButtonLoad()
{
    DataPercistenceManager.instance.loadGame();
}

public void ButtonSave()
{
    DataPercistenceManager.instance.saveGame();
}

}
