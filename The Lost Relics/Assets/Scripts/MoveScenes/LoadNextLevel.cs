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
    private Vector3 sceneStartPosition;
    [SerializeField]
    private GameObject player;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            //load the player at the start position of next scene
            player.transform.position = sceneStartPosition;
            
           // DataPercistenceManager.instance.saveGame();
            DataPercistenceManager.instance.nextScene(nextSceneName);
            SceneManager.LoadScene(nextSceneName);
  
        
        }

    }
 
}
