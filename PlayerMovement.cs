using System;
using System.Collections;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float _forwardForce = 50f;
    [SerializeField] private float _sidewaysForce = 20f;

    private Rigidbody _rigedBody;
    private float _deadPositionY = -1;
    private bool _canMove = true;
    private void Awake()
    {
        _rigedBody = GetComponent<Rigidbody>();
        gameObject.tag = "Player";
    }
    private void FixedUpdate()
    {
        if(_canMove)
            _rigedBody.AddForce(0, 0, _forwardForce);
        if (_rigedBody.position.y <= _deadPositionY)
            FindObjectOfType<GameManagers>().EndGame();
    }
    public void StopMove()
    {
        _canMove = false;
    }
    public void GoLeft()
    {
        if(_canMove)
        {
            _rigedBody.AddForce(-_sidewaysForce, 0, 0, ForceMode.VelocityChange);
            StartCoroutine(FasterPlayer(1));
        }
    }
    public void GoRight()
    {
        if(_canMove)
        {
            _rigedBody.AddForce(_sidewaysForce, 0, 0, ForceMode.VelocityChange);
            StartCoroutine(FasterPlayer(1));
        }
    }
    private IEnumerator FasterPlayer(float waitSec)
    {
        _sidewaysForce++;
        yield return new WaitForSeconds(waitSec);
        _sidewaysForce--;
    }
}