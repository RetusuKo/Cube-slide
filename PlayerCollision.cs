using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private int _tryCount;
    private PlayerMovement _movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == "Obstacle")
        {
            _movement.enabled = false;
            FindObjectOfType<GameManagers>().EndGame();
        }
    }
}
