using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public class Target : MonoBehaviour
    {
        public int maxhealth = 50;
        public int currhealth;
        public Healthbar healthbar;
        public bool isdead = false;
    public ChangeLevel changeLevel;
        public bool IsEnemyDead()
        {
            return isdead;
        }

        public void Start()
        {
        changeLevel = GetComponent<ChangeLevel>();
            currhealth = maxhealth;
            healthbar.SetMaxHealth(maxhealth);
        }
        public void TakeDamage(int amount)
        {
            currhealth -= amount;
            healthbar.SetHealth(currhealth);
            if (currhealth <= 0)
            {
                Die();
            }
        }

        public void Die()
        {
            isdead = true;
        changeLevel.NextLevel();
            Destroy(gameObject);
        }

       
    }


