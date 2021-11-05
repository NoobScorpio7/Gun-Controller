
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public List<GameObject> getLevels;
    public GameObject levelSelection;
    public GameObject selectGun;


    void Start()
    {


    }

    void Update()
    {


    }

    public void loadLevel(int index)
    {
        PlayerPrefs.SetInt("loadlevel", index);
        levelSelection.gameObject.SetActive(false);
        selectGun.gameObject.SetActive(true);
    }

    public void changeLevel()
    {
        SceneManager.LoadScene(1);
        int load = PlayerPrefs.GetInt("loadlevel");
        getLevels[load].gameObject.SetActive(true);
    }
    

}    
