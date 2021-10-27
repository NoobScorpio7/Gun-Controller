using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public int maxhealth = 50;
    public int currhealth;
    public Healthbar healthbar;

    public void Start()
    {
        currhealth = maxhealth;
        healthbar.SetMaxHealth(maxhealth);
    }
    public void TakeDamage(int amount)
    {
        currhealth -= amount;
        healthbar.SetHealth(currhealth);
        if (currhealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}