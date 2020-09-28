using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxAddScore : MonoBehaviour
{
    private UIManager uiManager;

    private bool triggered = false;

    // Start is called before the first frame update
    void Start()
    {
        uiManager = GameObject.FindObjectOfType<UIManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !triggered)
        {
            triggered = true;
            uiManager.score++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
