using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text highScore;
    public float scoreValue = 0f;
    public float pointIncreasedPerSecond = 1f;



    public GameObject Player;

    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {


        if (Player != null)
        {
            scoreText.text = ((int)scoreValue).ToString();
            scoreValue += pointIncreasedPerSecond * Time.fixedDeltaTime;



        }

        else
        {
            if (scoreValue > PlayerPrefs.GetInt("HighScore", 0))
            {   
                
                PlayerPrefs.SetInt("HighScore", (int)scoreValue);
                highScore.text = ((int)scoreValue).ToString();
                scoreValue = 0f;
            }
        }

    
    
    }
        
    public void resetScore()
    {
        PlayerPrefs.DeleteKey("HighScore");
        scoreValue = 0f;
        highScore.text = "0";
    }




}
