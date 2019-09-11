using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public AudioSource scorefx;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        scorefx.Play();
        Score.score++;
    }

}
