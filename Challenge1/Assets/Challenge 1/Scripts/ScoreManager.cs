using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public Text textbox;
    public static bool isGameOver;
    public static int score;

    private static bool hasWon;

    // Start is called before the first frame update
    void Start()
    {
        hasWon = false;
        isGameOver = false;
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
       if(!isGameOver)
        {
            textbox.text = "Score: " + score;
        }

        if (score >= 5)
        {
            hasWon = true;
            isGameOver = true;
        }

        if (isGameOver)
        {
            if(hasWon)
            {
                textbox.text = "You win\nPress R to Try Again!";
            }
            else
            {
                textbox.text = "You Lose\nPress R to Try Again!";
            }
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
