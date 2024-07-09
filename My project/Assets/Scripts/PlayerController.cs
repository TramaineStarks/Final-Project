using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControls : MonoBehaviour
{
    public CharacterController controller;

    public float moveSpeed = 5f;

    public float rotateSpeed = 5f;

    public int health;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    
    void Update()
    {
       float horizontalInput = Input.GetAxis("Horizontal");
       float verticalInput = Input.GetAxis("Vertical");  

       Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

       controller.Move(movement * moveSpeed * Time.deltaTime);

       if (movement != Vector3.zero)
       {
        Quaternion targetRotation = Quaternion.LookRotation(movement);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotateSpeed * Time.deltaTime);

       }
    }
}
