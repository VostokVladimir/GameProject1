using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_1 : MonoBehaviour
{
    
    public GameObject EnemyPrefab;
    public Transform PositionEnemy;

    private void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {

        var g06 = Instantiate(EnemyPrefab, PositionEnemy.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {

    }

    void FixedUpdate()
    {

    }

    void LateUpdate()
    {

    }
}
