using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider collider)
    {
        if(collider.tag == "Player")
            FindObjectOfType<GameManagers>().CompleteLevel();
    }
}
