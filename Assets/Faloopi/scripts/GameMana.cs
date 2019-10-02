using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMana : MonoBehaviour
{

    public GameObject Game_Over_Canvas;
    public AudioSource btnbtnfx;

    public string Faloopi_Game { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    public void GameOver()
    {
        Game_Over_Canvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void replay()
    {
        btnbtnfx.Play();
        SceneManager.LoadScene(4);
    }

    public void exitToHub()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Hub");
    }
}
