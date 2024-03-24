using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pauseMenu : MonoBehaviour
{
    public static bool gameIsPaused = false;

    public GameObject pauseMenuUI;
    public GameObject pauseButton;
    public GameObject resetButton;
    public GameObject restartButton;



    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        pauseButton.SetActive(false);
        resetButton.SetActive(false);
        restartButton.SetActive(false);

        Time.timeScale = 0.0f;
    }

    public void resume()
    {
        pauseMenuUI.SetActive(false);
        pauseButton.SetActive(true);
        resetButton.SetActive(true);
        restartButton.SetActive(true);

        Time.timeScale = 1.0f;
    }
}
