using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public int score = 0;
    public Text scoretext;
    public PlayerControllerX playerControllerScript;
    public bool won;

    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerControllerX>();

        scoretext.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        if(!playerControllerScript.gameOver)
        {
            scoretext.text = "Score: " + score;
        }

        if(playerControllerScript.gameOver && !won)
        {
            scoretext.text = "You lose! Press R to try Again!";
        }

        if(score >= 20)
        {
            playerControllerScript.gameOver = true;
            won = true;

            scoretext.text = "You win! Press R to play Again!";
        }
    }
}
