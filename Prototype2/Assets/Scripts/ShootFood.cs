using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootFood : MonoBehaviour
{
    public GameObject foodToShoot;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(foodToShoot, transform.position, foodToShoot.transform.rotation);
        }
        
    }
}
