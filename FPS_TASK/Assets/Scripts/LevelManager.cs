using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LevelManager : MonoBehaviour
{
    public List<GameObject> Levels;
    public int currLevel=0;
    public int EnemiesCount;
    public static LevelManager instance;
       
    void Start()
    {

    }


    void Update()
    {
        
        
    }

    
    public void NextLevel()
    {
        
       
        PlayerPrefs.SetInt("level", currLevel);
        if(currLevel > Levels.Count-1)
        {
            currLevel = 0;
        }
        else
        {
            Levels[currLevel].gameObject.SetActive(true);
            EnemiesCount = Levels[currLevel].gameObject.transform.childCount;
            PlayerPrefs.SetInt("enemies", EnemiesCount);
            currLevel++;
        }
    }
   

}
