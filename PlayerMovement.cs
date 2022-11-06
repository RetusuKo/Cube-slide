using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody _rigedBody;
    [SerializeField] private float _forwardForce = 50f;
    [SerializeField] private float _sidewaysForce = 20f;
    private void Awake()
    {
        _rigedBody = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        _rigedBody.AddForce(0, 0, _forwardForce);
    }
    public void GoLeft()
    {
        _rigedBody.AddForce(_sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        print("left");
    }
    public void GoRight()
    {
        _rigedBody.AddForce(-_sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        print("right");
    }
}
