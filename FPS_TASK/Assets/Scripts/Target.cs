using System.Collections;
using System.Collections.Generic;
using UnityEngine;




    public class Target : MonoBehaviour
    {
        public int maxhealth = 50;
        public int currhealth;
        public Healthbar healthbar;
        public bool isdead = false;

        public void Start()
        {
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

        void Die()
        {
            isdead = true;
            Destroy(gameObject);
        }

        public bool IsEnemyDead()
        {
            return isdead;
        }
    }

