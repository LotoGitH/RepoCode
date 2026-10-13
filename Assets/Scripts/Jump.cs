using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Jump : MonoBehaviour
{
    [SerializeField]
    private InputActionAsset inputActionAsset;
    InputAction jumpAction;

    private void OnEnable()
    {
        inputActionAsset.FindActionMap("Player").Enable();
    }
    
    private void OnDisable()
    {
        inputActionAsset.FindActionMap("Player").Disable();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        jumpAction = inputActionAsset.FindActionMap("Player").FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        if (jumpAction.WasPerformedThisFrame())
        {
            gameObject.GetComponent<Rigidbody>().AddForce(Vector3.up * 500f);
        }   
    }
}
