using System;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    [SerializeField] float forwardForce = 50f;
    [SerializeField] float sidewaysForce = 20f;
   
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.touchCount > 0)
        {
            rb.AddForce(sidewaysForce  * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.touchCount == 0)
        {
            rb.AddForce(-15 * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManagers>().EndGame();
        }
    }
}
