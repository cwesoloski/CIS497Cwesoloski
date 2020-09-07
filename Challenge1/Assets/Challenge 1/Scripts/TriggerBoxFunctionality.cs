using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxFunctionality : MonoBehaviour
{
    private bool isTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !isTriggered)
        {
            isTriggered = true;
            ScoreManager.score++;
        }
    }
}
