using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class FlyLittleBret : MonoBehaviour
{
    public GameMana gameManager;
    public float velocity = 1;
    public AudioSource flyfx;
    public AudioSource boomfx;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetKeyDown("space"))

        Keyboard kb = InputSystem.GetDevice<Keyboard>();

        if (kb.spaceKey.wasPressedThisFrame)
        {
            flyfx.Play();
            rb.velocity = Vector2.up * velocity;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        boomfx.Play();
        gameManager.GameOver();
    }
}
