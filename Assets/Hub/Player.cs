using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour, PlayerHubInput.IPlayerActions
{
    [SerializeField] public static int levelScale = 100;
    [SerializeField] private PlayerHubInput controls;
    [SerializeField] private float speed = 3f;
    [SerializeField] private float horizontal;
    [SerializeField] private float vertical;

    [SerializeField] private int playerLevel; 
    //Player will have a level, experience will be gained from minigames
    private PlayerLevelManager playerLevelManager;
    void Awake()
    {
        controls = new PlayerHubInput();
        controls.Player.SetCallbacks(this);
        playerLevelManager = new PlayerLevelManager(levelScale);
    }

    private void OnEnable()
    {
        controls.Player.Movement.Enable();
        controls.Player.Action1.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Movement.Disable();
        controls.Player.Action1.Disable();
    }

    private void Update()
    {
        transform.position += new Vector3(horizontal * Time.deltaTime * speed, 0.0f, vertical * Time.deltaTime * speed);
        this.GetComponent<Rigidbody>().velocity = Vector3.zero;
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;
    }

    public void OnAction1(InputAction.CallbackContext context)
    {
        if (EnterFaloopiGame.shouldEnterScene) {
            SceneManager.LoadScene("Faloopi_Game", LoadSceneMode.Single);
        }
        if (EnterScene2.shouldEnterScene) {
            SceneManager.LoadScene("Game2", LoadSceneMode.Single);
        }
    }
}
