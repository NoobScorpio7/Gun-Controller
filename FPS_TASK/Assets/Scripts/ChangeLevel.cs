
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public int currLevel;
    Target target;
    public List<GameObject> levels;
    public int totalEnemies;
    
    
   
    void Start()
    {
        target = transform.GetComponent<Target>();
    }
    
    public void NextLevel()
    {
         if (currLevel < levels.Count-1)
         {
             currLevel++;
             print("CURRENT LEVEL: " + currLevel);
             GameObject enemy = levels[currLevel];

             target.setValues(currLevel, enemy);
             enemy.SetActive(true);
            
        }
         else
         {
            currLevel = 0;
             
           
         }
         
    }

   /* public int getTotalEnemies(GameObject enemyCount)
    {
        totalEnemies = enemyCount.transform.childCount;
        return totalEnemies;
    }*/





}
