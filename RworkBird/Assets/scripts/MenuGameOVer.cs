using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuGameOVer : MonoBehaviour
{

    [SerializeField]
    GameObject gameOverPanel;

    Pause pause;

    private void Awake()
    {
        pause = FindObjectOfType<Pause>();
    }

    public void GameOver()
    {
        pause.isGameOver = true;
        Time.timeScale = 0f;
        gameOverPanel.gameObject.SetActive(true);
    }

    public void Restart()
    {
        pause.isGameOver = false;
        gameOverPanel.SetActive(false);
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
