using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutofBounds : MonoBehaviour
{
    void Update()
    {
        if(transform.position.y < -51 || transform.position.y > 80)
        {
            ScoreManager.isGameOver = true;
        }
    }
}
