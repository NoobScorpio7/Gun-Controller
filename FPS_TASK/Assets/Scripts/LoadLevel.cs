using System.Collections;
using System.Collections.Generic;
using UnityEngine;





    public class LoadLevel : MonoBehaviour
    {
        int CurrLevel = -1;
        public List<GameObject> levels;
        public List<GameObject> prefabObjects;

        [HideInInspector]
        public GameObject Level;
        

    private void Start()
    {
        
    }

    void Update()
    {

    }



        public void NextLevel()
        {
            if (CurrLevel < levels.Count - 1) CurrLevel++;
            if (Level)
            {
                Level.SetActive(false);
                Destroy(Level);
            }
            Level = Instantiate(levels[CurrLevel]);
            ReplaceObjects();
            Level.SetActive(false);
        }

        public void ReplaceObjects()
        {
            Object[] sceneObjects = GameObject.FindObjectsOfType(typeof(GameObject));
            foreach (Object sceneObject in sceneObjects)
            {
                GameObject currObject = (GameObject)sceneObject;
                if (currObject.activeInHierarchy)
                {
                    for (int i = 0; i < prefabObjects.Count; i++)
                    {
                        if (currObject.name.StartsWith(prefabObjects[i].name))
                        {
                            GameObject newObject = (GameObject)Instantiate(prefabObjects[i],
                                currObject.transform.position, Quaternion.identity) as GameObject;
                            newObject.transform.SetParent(Level.transform);
                            newObject.name = prefabObjects[i].name;
                            Destroy(currObject);

                        }
                    }
                }
            }
        }
        

    }

