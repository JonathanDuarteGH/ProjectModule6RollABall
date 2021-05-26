using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    InputManager inputManager;
    ThirdPersonMovement tfMovement;

    private void Awake()
    {
        inputManager = GetComponent<InputManager>();
        tfMovement = GetComponent<ThirdPersonMovement>();
    }

    private void Update()
    {
        inputManager.HandleAllInputs();
    }

    private void FixedUpdate()
    {
        tfMovement.HandleAllMovement();
    }

    private void OnTriggerEnter(Collider other)
    {
        // Collect pick ups
        if (other.CompareTag("PickUp"))
        {
            Debug.Log("Pick up collected!");
            GameObject.Destroy(other.gameObject);
        }
    }
}