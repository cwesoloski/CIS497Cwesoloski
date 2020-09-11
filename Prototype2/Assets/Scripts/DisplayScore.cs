using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour
{
    public Text textbox;

    public int score;

    // Start is called before the first frame update
    void Start()
    {
        //set reference 
        textbox = GetComponent<Text>();

        textbox.text = "Score: ";
    }

    // Update is called once per frame
    void Update()
    {
        textbox.text = "Score: " + score;
    }
}
