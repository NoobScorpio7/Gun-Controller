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
    public int Enemies;
    public int selectLevel;
    public int select;
    private static LevelManager n_instance;
    public int levelComplete = 1;
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
        
        SetEnemies();
        LoadLevel();
     
    }
    private void Update()
    {
        GetEnemies();
    }


    private void LoadLevel()
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

    private void SetEnemies()
    {
        if (selectLevel == 0)
        {
            Enemies = 1;
        }
        else if (selectLevel == 1)
        {
            Enemies = 2;
        }
        else if (selectLevel == 2)
        {
            Enemies = 3;
        }
        else if (selectLevel == 3)
        {
            Enemies = 4;
        }
        else
        {
            Enemies = 5;
        }
    }
 
    private void GetEnemies()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        if (enemies.Length == 0)
        {
            SceneManager.LoadScene("Game");
            PlayerPrefs.SetInt("LevelNoT", selectLevel + 1);
            PlayerPrefs.SetInt("levelComplete", levelComplete + 1);

        }
        if (selectLevel > level.Length - 1)
        {
            PlayerPrefs.SetInt("levelComplete", 1);
            PlayerPrefs.SetInt("LevelNoT", 0); return;

        }
    }
}
