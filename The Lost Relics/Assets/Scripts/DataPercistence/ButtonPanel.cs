using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonPanel : MonoBehaviour
{

    public GameObject Panel;

    public void OpenPanel()
    {
        if (Panel != null)
        {
            Panel.SetActive(true);
        }
    }

    public void ClosePanel()
    {
        StartCoroutine(RemoveAfterSeconds(2));

        IEnumerator RemoveAfterSeconds(int seconds)
        {
            yield return new WaitForSeconds(seconds);
            Panel.SetActive(false);
        }
    }

}
