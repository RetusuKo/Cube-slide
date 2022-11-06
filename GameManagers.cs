using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagers : MonoBehaviour
{
    private bool _gameHasEnded = false;

    private float _restartDelay = 1f;

    private GameObject _complateLevelUI;

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