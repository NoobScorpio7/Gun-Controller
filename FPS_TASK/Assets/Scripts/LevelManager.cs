using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;


public class LevelManager : MonoBehaviour
{
    /*public List<GameObject> Levels;
    public int currLevel=1;
    public int EnemiesCount;
    public static LevelManager instance;
    bool nL = false;    
       
    void Start()
    {
        instance = this;
        NextLevel();
    }


    void Update()
    {
        
        
    }

    
    public void NextLevel()
    {
        
       
        PlayerPrefs.SetInt("level", currLevel);
        currLevel = PlayerPrefs.GetInt("level");
        if (currLevel < Levels.Count)
        {
            Levels[currLevel].gameObject.SetActive(true);
            EnemiesCount = Levels[currLevel].gameObject.transform.childCount;
            PlayerPrefs.SetInt("enemies", EnemiesCount);
            PlayerPrefs.SetInt("level", currLevel+1);
        }
        else
        {
            currLevel = 0;
        }
    }*/


    public GameObject[] level;
    public GameObject[] enemies;
    public int selectLevel;
    public int select;
    private static LevelManager n_instance;
    public static LevelManager Instance
    {
        get
        {
            return n_instance;
        }
    }
    public void Awake()
    {
        n_instance = this;
    }
    public void Start()
    {
        selectLevel = PlayerPrefs.GetInt("LevelNoT");
        
        
            for (int i = 0; i < level.Length; i++)
            {

                if (i == selectLevel)
                {
                    level[i].SetActive(true);
                }
                else
                {
                    level[i].SetActive(false);
                }
            }
        
    }
    //**********************************************//
    private void Update()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)
        {
            SceneManager.LoadScene("Game");
            PlayerPrefs.SetInt("LevelNoT", selectLevel + 1);
        }
        if (selectLevel > level.Length - 1)
        {
            PlayerPrefs.SetInt("LevelNoT", 0); return;
        }
    }



}
