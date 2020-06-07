using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    private CharacterController _controller;
    private float _speed = 20.5f;
    private float _gravity = 9.81f;

    void Start()
    {
        _controller = GetComponent<CharacterController>();
          
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis ("Horizontal");
        float VerticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3 (horizontalInput, 0 , VerticalInput);
        Vector3 velocity = direction * _speed;
        velocity.y -= _gravity;

        velocity = transform.transform.TransformDirection(velocity);
        _controller.Move(velocity * Time.deltaTime);
    }
}
