using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerrator : MonoBehaviour
{
    private const float PlayerDistanceSpawnLevelPart = 200f;

    [SerializeField] private Transform _levelPartStart;
    [SerializeField] private List<Transform> _levelPartList;
    [SerializeField] private GameObject _player;

    private Vector3 _lastEndPosition;
    private void Awake()
    {
        _lastEndPosition = _levelPartStart.Find("EndPosition").position;
        int startingSpawnLevelParts = 5;
        for (int i = 0; i < startingSpawnLevelParts; i++)
        {
            SpawnLevelPart();
        }
    }
    private void Update()
    {
        if (Vector3.Distance(_player.transform.position, _lastEndPosition) < PlayerDistanceSpawnLevelPart)
        {
            SpawnLevelPart();
        }
    }
    private void SpawnLevelPart()
    {
        Transform chosenLevelPart = _levelPartList[Random.Range(0, _levelPartList.Count)];
        Transform lastLevelPartTransform =  SpawnLevelPart(chosenLevelPart, _lastEndPosition);
        _lastEndPosition = lastLevelPartTransform.Find("EndPosition").position + new Vector3(0, 0, 0);
    }
    private Transform SpawnLevelPart(Transform levelPart, Vector3 spawnPosition)
    {
        Transform levelPartTransform = Instantiate(levelPart, spawnPosition, Quaternion.identity);
        return levelPartTransform;
    }
}
