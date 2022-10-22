using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToTown : MonoBehaviour
{

    [SerializeField]
    private string nextSceneName;
    [SerializeField]
    private Vector3 sceneStartPosition;
    [SerializeField]
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void ShowReturnMenu()
    {

    }

    public void ReturnToTownYes()
    {
        player.transform.position = sceneStartPosition;
        DataPercistenceManager.instance.saveGame();
        SceneManager.LoadScene(nextSceneName);
    }

    public void ReturnToTownNo()
    {
        return;
    }
}
