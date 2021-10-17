using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrrigger : MonoBehaviour
{
    public GameManagers gameManager;
    void OnTriggerEnter()
    {
        gameManager.CompleteLevel();
    }
}
