using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject GameOvercanvas;
    public GameObject nextLevelPanel;

    public void nextLevel()
    {
        nextLevelPanel.SetActive(true);
    }

    public void loadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Loading Next Level");
    }

    public void EndGame()
    {
        GameOvercanvas.SetActive(true);
        PlayerMoves.isMove = false;
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Debug.Log("Restart");
    }
}
