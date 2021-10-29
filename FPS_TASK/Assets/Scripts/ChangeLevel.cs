
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLevel : MonoBehaviour
{
    public int currLevel = 0;
    Target target;

    public List<GameObject> levels;
   
    void Start()
    {
        target = transform.GetComponent<Target>();
    }

    // Update is called once per frame
   /* void Update()
    {
        NextLevel();
        
    }
   */
    public void NextLevel()
    {
        
        foreach (GameObject enemy in levels)
        {
            
            if (!target.isdead)
            {
                print("enemy spawn");
                enemy.gameObject.SetActive(true);
            }
           
        }
    }


}
