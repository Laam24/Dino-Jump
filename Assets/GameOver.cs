using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject pauseButton;
    public GameObject resetButton;
    public GameObject restartButton;

    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        gameIsOver();
    }

    public void gameIsOver()
    {
        if (Player == null)
        {
            gameOverUI.SetActive(true);
            pauseButton.SetActive(false);


            Time.timeScale = 0.0f;
        }
            
    }
}
