using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Target : MonoBehaviour
{
    public int maxhealth = 50;
    public int currhealth;
    public Healthbar healthbar;
    public bool isdead = false;
    ChangeLevel changeLevel;
    
      public int CurrentLevel;
    public int totalEnemies;

    
    public void Start()
    {
         changeLevel = GetComponent<ChangeLevel>();
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
    

    public void Die()
    {
        
        isdead = true;
        gameObject.SetActive(false);
        if(totalEnemies == 0)
        {
            changeLevel.NextLevel();
        }
        else
        {
            totalEnemies--;
            print(totalEnemies + " enemies");
        }
        
       
    }

    public void setValues(int level, GameObject enemies)
    {

        CurrentLevel += level;
        totalEnemies = enemies.transform.childCount;
        print("TOTAL ENEMIES: " + totalEnemies);
    }




}


