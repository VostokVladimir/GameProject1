using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Distance : MonoBehaviour
{
    [SerializeField] private GameObject Bulet;
    [SerializeField] private float Speed;
    [SerializeField] private GameObject PrefabLaser;
    [SerializeField] private Transform  ShotSpawn;
    public float fireRate = 1.5f;
    public float nextFire = 0.0f;
    private bool playerInZone = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            playerInZone = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerInZone = false;
        }
    }



    public void Update()
    {
        if (playerInZone == true)
        {
            if (Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                //Instantiate(PrefabLaser, ShotSpawn.position, ShotSpawn.rotation);

                Instantiate(Bulet, ShotSpawn.position, ShotSpawn.rotation);
            }
        }
           
           

    }


}
