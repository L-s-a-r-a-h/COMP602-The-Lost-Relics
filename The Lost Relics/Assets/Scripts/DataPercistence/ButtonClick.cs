using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonClick : MonoBehaviour
{

public void ButtonLoad()
{
        Debug.Log("button load");
       // DataPercistenceManager.instance.loadScene();
        DataPercistenceManager.instance.ButtonLoad();
}

public void ButtonSave()
{

    DataPercistenceManager.instance.ButtonSave();

}

}
