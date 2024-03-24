using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startGame()
    {

        SceneManager.LoadScene("Gameplay");
        Time.timeScale = 1f;
    }

    public void options()
    {
        SceneManager.LoadScene("Options");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }

    
}
