using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagers : MonoBehaviour
{
    [SerializeField] private GameObject _complateLevelUI;

    private bool _gameHasEnded = false;
    private float _restartDelay = 1f;

    public void CompleteLevel()
    {
        _complateLevelUI.SetActive(true);
    }
    public void EndGame ()
    {
        if (_gameHasEnded == false)
        {
            _gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke("Restart", _restartDelay);
        }
    }
    private void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}