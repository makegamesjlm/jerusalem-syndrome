using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour, PlayerHubInput.IPlayerActions
{
    [SerializeField] private PlayerHubInput controls;
    [SerializeField] private float speed = 3f;

    private float horizontal;
    private float vertical;
    void Awake()
    {
        controls = new PlayerHubInput();
        controls.Player.SetCallbacks(this);
    }

    private void OnEnable()
    {
        controls.Player.Movement.Enable();
    }

    private void OnDisable()
    {
        controls.Player.Movement.Disable();
    }

    private void Update()
    {
        transform.position += new Vector3(horizontal * Time.deltaTime * speed, 0.0f, vertical * Time.deltaTime * speed);
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
        vertical = context.ReadValue<Vector2>().y;
    }
}
