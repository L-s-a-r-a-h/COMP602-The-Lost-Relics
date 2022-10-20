using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class returnManager : MonoBehaviour
{

    public static returnManager instance;

    private void Awake()
    {
        if (returnManager.instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void RelicCollected()
    {

        ShowReturnMenu();

    }


    [SerializeField] private GameObject returnPanel;
    [SerializeField]
    private string nextSceneName;
    [SerializeField]
    private Vector3 sceneStartPosition;
    [SerializeField]
    private GameObject player;
    // Start is called before the first frame update

    public void ShowReturnMenu()
    {
        returnPanel.SetActive(true);
    }

    public void ReturnToTownYes()
    {
        player.transform.position = sceneStartPosition;
        DataPercistenceManager.instance.nextScene(nextSceneName);
        SceneManager.LoadScene(nextSceneName);
    }

    public void ReturnToTownNo()
    {
        returnPanel.SetActive(false);

        return;
    }
}
