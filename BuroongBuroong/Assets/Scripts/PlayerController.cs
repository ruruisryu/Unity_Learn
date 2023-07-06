using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20f;
    [SerializeField] private float turnSpeed = 30f;
    [SerializeField] private float horizontalInput;
    [SerializeField] private float forwardInput;
    [SerializeField] private float _yAngle = 0f;
    void Start()
    {
        
    }

    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        _yAngle += horizontalInput * Time.deltaTime * turnSpeed;
        
        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        // Rotate the vehicle
        // transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        // transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        transform.rotation = Quaternion.Euler(new Vector3(0.0f, _yAngle, 0.0f));
    }
}
