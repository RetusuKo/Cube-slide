using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrrigger : MonoBehaviour
{
    private GameManagers _gameManager;
    void OnTriggerEnter()
    {
        _gameManager.CompleteLevel();
    }
}
