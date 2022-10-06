using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadedScene : MonoBehaviour
{
    // Start is called before the first frame update
    public static LoadedScene scene { get; private set; }
    [SerializeField]
    private GameObject player;

    public void LoadScenePosition(Vector3 position)
    {
        player.transform.position = position;

    }


}
