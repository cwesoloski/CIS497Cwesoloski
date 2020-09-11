using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutofBouds : MonoBehaviour
{
    public float topBound = 30;
    public float bottomBound = -10;

    private HealthSystem healthsystem;

    private void Start()
    {
        healthsystem = GameObject.FindGameObjectWithTag("Health System").GetComponent<HealthSystem>();

    }

    // Update is called once per frame
    void Update()
    {
       if(transform.position.z > topBound)
        {
            Destroy(gameObject);
        }

       if(transform.position.z < bottomBound)
        {

            //grab health system script and call the takeDamage()
            healthsystem.TakeDamage();

            Destroy(gameObject);
        }
    }
}
