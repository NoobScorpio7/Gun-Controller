
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ChangeLevel : MonoBehaviour
{
    public List<GameObject> getLevels;
    public List<Button> buttons;
    public List<GameObject> anime;
    public GameObject curretScene;
    public GameObject NextScene;
    public int levelcomplete=1;


    void Start()
    {
        PlayerPrefs.SetInt("levelComplete", levelcomplete);
        


    }

    void Update()
    {
        levelcomplete = PlayerPrefs.GetInt("levelComplete");
        
        for (int i = levelcomplete; i < getLevels.Count; i++)
        {
           
            buttons[i].interactable = false;
            anime[i].gameObject.SetActive(true);
        }

    }

    public void loadLevel(int index)
    {
        PlayerPrefs.SetInt("LevelNoT", index);
        curretScene.gameObject.SetActive(false);
        NextScene.gameObject.SetActive(true);
    }

    public void changeLevel()
    {
        SceneManager.LoadScene(1);
        int load = PlayerPrefs.GetInt("LevelNoT");
        getLevels[load].gameObject.SetActive(true);
    }




    

}    
