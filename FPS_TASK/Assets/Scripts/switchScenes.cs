using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class switchScenes : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject levelSelection;
    void OnMouseUp()
    {
        Debug.Log("MouseHit");
        mainMenu.SetActive(false);
        levelSelection.SetActive(true);
    }
}
