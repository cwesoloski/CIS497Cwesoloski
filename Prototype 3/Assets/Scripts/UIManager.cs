using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public PlayerController playerControllerScript;
    public bool won = false;

    // Start is called before the first frame update
    void Start()
    {
        if (scoreText == null)
        {
            scoreText = FindObjectOfType<Text>();
        }

        if (playerControllerScript == null)
        {
            playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>();
        }

        scoreText.text = "Score: 0";
    }

    // Update is called once per frame
    void Update()
    {
        //Display Score until the game is over
        if(!playerControllerScript.gameOver)
        {
            scoreText.text = "Score: " + score;
        }

        //Loss condition: Hit bomb (even once)
        if (playerControllerScript.gameOver && !won)
        {
            scoreText.text = "You Lose!" + "\n" + "Press R to try again.";
        }

        //Wind Condition 10 points
        if(score >= 10)
        {
            playerControllerScript.gameOver = true; ;
            won = true;

            scoreText.text = "You Win!" + "\n" + "Press R to play again!";
        }

        //Reset the game if the player hits R
        if (playerControllerScript.gameOver && Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
