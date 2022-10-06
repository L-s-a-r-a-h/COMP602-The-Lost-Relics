using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class LoadNextLevel : MonoBehaviour
{
    [SerializeField]
    private string nextSceneName;
    [SerializeField]
    private Vector3 loadPosition;
    [SerializeField]
    private GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("scene Load");
            DataPercistenceManager.instance.saveGame();
            SceneManager.LoadScene(nextSceneName);
            Debug.Log("next scene loaded");
            player.transform.position = loadPosition;
            Debug.Log(loadPosition.ToString());
        
        }

    }
   /* void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }*/
}
