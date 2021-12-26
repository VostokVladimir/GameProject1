using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1Moove : MonoBehaviour
{
    [SerializeField] private Transform StartWayFromEnemy1;
    [SerializeField] private Transform StopWayToEnemy1;
    public float Speed=8;
    public GameObject Prefab;
    private GameObject _EnemyGo;
    
    bool flag = true;
    // Start is called before the first frame update

    void Mooving()
    { }
    /// <summary>
    /// метод для цикличного движения
    /// </summary>
    /// <param name="_EnemyGO"></param> game object который двигается
    /// <param name="StartPosition"></param> начальная точка
    /// <param name="EndPosition"></param> конечная точка
    void Mooving(GameObject _EnemyGO,Transform StartPosition,Transform EndPosition)
    {
        _EnemyGo = _EnemyGO;
        StartWayFromEnemy1 = StartPosition;
        StopWayToEnemy1 = EndPosition;

        if (flag == true)
        {
            _EnemyGo.transform.LookAt(StopWayToEnemy1, Vector3.up);
            _EnemyGo.transform.position = Vector3.MoveTowards(_EnemyGo.transform.position, StopWayToEnemy1.position, Speed * Time.deltaTime);
            if (_EnemyGo.transform.position == StopWayToEnemy1.transform.position)
            {
                _EnemyGo.transform.LookAt(StartWayFromEnemy1, Vector3.up);
                flag = false;

            }

        }
        else if (flag == false)
        {
            _EnemyGo.transform.position = Vector3.MoveTowards(_EnemyGo.transform.position, StartWayFromEnemy1.position, Speed * Time.deltaTime);
            if (_EnemyGo.transform.position == StartWayFromEnemy1.position)
            {
                _EnemyGo.transform.LookAt(StopWayToEnemy1, Vector3.up);
                flag = true;

            }

        }

    }

    void Start()
    {
        _EnemyGo = Instantiate(Prefab, StartWayFromEnemy1.position, Quaternion.identity);
      
    }

    // Update is called once per frame
    void Update()
       
    {    
            
        Mooving(_EnemyGo, StartWayFromEnemy1, StopWayToEnemy1);
       
    }
}
