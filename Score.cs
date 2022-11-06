using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] private Transform _player;
    [SerializeField] private Text _scoreText;
    void Update()
    {
        _scoreText.text = _player.position.z.ToString("0");
    }
}
