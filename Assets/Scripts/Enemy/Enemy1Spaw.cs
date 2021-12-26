using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Spaw : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject EnemyPrefab;
    public Transform SpawnEnemy;
    //public Transform EndPositionEnemy;
    //[SerializeField] public float Speed;



    // Start is called before the first frame update
    public void Start()
    {

        var Enemy_1 = Instantiate(EnemyPrefab, SpawnEnemy.position, SpawnEnemy.rotation);

    }

    public void Update()
    {
        //EnemyPrefab.transform.position = EnemyPrefab.transform.position + EnemyPrefab.transform.forward * Time.deltaTime*3;
        // Enemy_1.transform.position = Vector3.MoveTowards(EnemyPrefab.transform.position, EndPositionEnemy.position, Time.deltaTime * Speed);
    }
}
