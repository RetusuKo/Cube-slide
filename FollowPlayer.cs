
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;
    public Vector3 offsset;
    void Update()
    {
        transform.position = player.position + offsset ;
    }
}