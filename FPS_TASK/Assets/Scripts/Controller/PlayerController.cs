using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    private void Start()
    {

    }


    void Update()
    {
        MovePlayer();
        
    }

    public void MovePlayer()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 position = this.transform.position;
            position.x--;
            this.transform.position = position;
        }

        if (Input.GetKey(KeyCode.S))
        {
            Vector3 position = this.transform.position;
            position.x++;
            this.transform.position = position;
        }
    }

   
    
}
