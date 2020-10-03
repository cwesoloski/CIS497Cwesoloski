using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    private ScoreScript displayScore;

    private void Start()
    {
        displayScore = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<ScoreScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);

        displayScore.score++;
    }
}
