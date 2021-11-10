using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Target : MonoBehaviour
{
    public int maxhealth = 50;
    public int currhealth;
    public Healthbar healthbar;
    public bool isdead = false;
    public CameraShaker cameraShake;
    int totalEnemies;
    

    
    public void Start()
    {
       
         currhealth = maxhealth;
         healthbar.SetMaxHealth(maxhealth);
    }


    public void Update()
    {
       
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
    public void Die()
    {
        isdead = true;
        
        Destroy(gameObject);
    
    }

    

}


