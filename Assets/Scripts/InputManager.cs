using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    TPControls tpControls;

    public Vector2 movementInput;
    public float verticalInput;
    public float horizontalInput;

    private void OnEnable()
    {
        if(tpControls == null)
        {
            tpControls = new TPControls();

            tpControls.GameplayControls.PlayerMove.performed += i => movementInput = i.ReadValue<Vector2>();
        }

        tpControls.Enable();

    }

    private void OnDisable()
    {
        tpControls.Disable();
    }

    public void HandleAllInputs()
    {
        HandleMovementInput();
        //HandleJumpingInput
        //HandleActionInput
    }

    private void HandleMovementInput()
    {
        verticalInput = movementInput.y;
        horizontalInput = movementInput.x;
    }
}
