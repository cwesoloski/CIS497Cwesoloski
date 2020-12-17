using UnityEngine;
using System.Collections;

public class Weapon: MonoBehaviour
{
    public int damageBonus;

    public Enemy enemyHoldingWeapon;

    public void Recharge()
    {
        Debug.Log("Recharging weapon");
    }

    private void Awake()
    {
        enemyHoldingWeapon = gameObject.GetComponent<Enemy>();
        EnemyEatsWeapon(enemyHoldingWeapon);
    }

    protected void EnemyEatsWeapon(Enemy enemyHolding)
    {
        Debug.Log("Enemy Eats weapon");
    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
