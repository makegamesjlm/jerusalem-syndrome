using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GamesHub : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void StartGame(GameDefinition gameDefinition)
    {
        SceneManager.LoadScene(gameDefinition.gameScene.name);
    }
    
    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
