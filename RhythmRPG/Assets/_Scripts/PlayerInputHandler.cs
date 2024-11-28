using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler
{
    public PlayerInputActions inputActions;

    private void Awake()
    {
        inputActions = new PlayerInputActions();
    }

    private void OnEnable()
    {
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Update()
    {
        if (inputActions.Player.Attack.WasPressedThisFrame())
        {
            Debug.Log("Attack button pressed!");
        }
        else if (inputActions.Player.Attack.IsPressed())
        {
            Debug.Log("Attack button is being held!");
        }
        else if (inputActions.Player.Attack.WasReleasedThisFrame())
        {
            Debug.Log("Attack button released!");
        }
    }
}
