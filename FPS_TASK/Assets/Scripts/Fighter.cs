using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    public int damage = 10;
    public float range = 100f;
    public Camera cam;
    AudioSource audioSource;
    public ParticleSystem muzzleFlash;
    public GameObject bulletEffect;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        Shoot();
    }

    private void Shoot()
    {
        RaycastHit hit;
        if (Input.GetButtonDown("Fire1"))
        {
            audioSource.Play();
            muzzleFlash.Play();
           
            if(Physics.Raycast(cam.transform.position, cam.transform.forward, out hit, range))
            {
                Debug.Log(hit.transform.name);
                Target target = hit.transform.GetComponent<Target>();
                if (target != null)
                {
                    target.TakeDamage(damage);

                }
                GameObject effect = Instantiate(bulletEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(effect, 1f);
            }

        }
        else { muzzleFlash.Stop(); }
        
    }
}
