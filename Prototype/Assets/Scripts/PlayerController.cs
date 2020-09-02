using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public float turnSpeed;
    private float moveHorizontal;
    private float moveVertical;
    // Update is called once per frame
    void Update()
    {
        moveHorizontal = Input.GetAxis("Horizontal");
        moveVertical = Input.GetAxis("Vertical");


        transform.Translate(Vector3.forward * Time.deltaTime * speed * moveVertical);

        transform.Rotate(Vector3.up, turnSpeed * Time.deltaTime * moveHorizontal);
    }
}
