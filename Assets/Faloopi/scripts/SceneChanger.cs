using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public AudioSource clickfx;

    public void replay()
    {
        clickfx.Play();
        SceneManager.LoadScene(4);
    }
}
