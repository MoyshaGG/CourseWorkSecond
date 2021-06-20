using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    [SerializeField]
    GameObject PausePanel;

    private bool gameIsPaused = false;
    private BallsLauncher ballLauncher;
    public bool isGameOver = false;
    private void Start()
    {
        ballLauncher = FindObjectOfType<BallsLauncher>();
        gameIsPaused = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isGameOver)
        {
            if (gameIsPaused)
            {
                Resume();
            }
            else
            {
                Paus();
            }
        }
    }
    public void Restart()
    {
       
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void Paus()
    {
        Time.timeScale = 0f;
        gameIsPaused = true;
        PausePanel.gameObject.SetActive(true);
    }

    public void Resume()
    {
        ballLauncher.GetComponent<LineRenderer>().startWidth = 0f;
        ballLauncher.GetComponent<LineRenderer>().endWidth = 0f;
        Input.ResetInputAxes();
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void GoToMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Menu");
    }
}
