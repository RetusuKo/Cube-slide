
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Vector3 _offsset;
    void Update()
    {
        transform.position = _player.position + _offsset ;
    }
}