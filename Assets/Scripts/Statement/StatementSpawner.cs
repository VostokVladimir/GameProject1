using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementSpawner : MonoBehaviour

{
    [SerializeField] private Transform _statementSpawnPoint1;
    
    [SerializeField] private GameObject _stateMentPrefab;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_stateMentPrefab, _statementSpawnPoint1.position, Quaternion.identity);
        

    }

}
