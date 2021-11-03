using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Data
{
    public int CurrentLevel;
    public int totalEnemies;

    public Data(int level, GameObject enemies)
    {
        CurrentLevel += level;
        totalEnemies = enemies.transform.childCount; 
        
    }

   

    public int SetTotalEnemies(int count)
    {
        totalEnemies -= count;
        return totalEnemies;
    }

    

}
