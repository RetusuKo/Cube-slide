using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyCreateObject : MonoBehaviour
{
    [SerializeField] private GameObject _createdObject;
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            StartCoroutine(DestroyObject(2));
        }
    }
    private IEnumerator DestroyObject(float waitSec)
    {
        yield return new WaitForSeconds(waitSec);
        Destroy(_createdObject);
    }
}
