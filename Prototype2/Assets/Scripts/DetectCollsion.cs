using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollsion : MonoBehaviour
{
    private DisplayScore displayscore;

    private void Start()
    {
        displayscore = GameObject.FindGameObjectWithTag("DisplayScoreText").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayscore.score++;
        Destroy(other.gameObject);
        Destroy(gameObject);
    }
}
