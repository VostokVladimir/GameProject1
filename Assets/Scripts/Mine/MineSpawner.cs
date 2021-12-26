using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MineSpawner : MonoBehaviour
{   [SerializeField] private GameObject _mine;
    [SerializeField] private Transform _minespawn1;
    [SerializeField] private Transform _minespawn2;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(_mine, _minespawn1.position, Quaternion.identity);
        Instantiate(_mine, _minespawn2.position, Quaternion.identity);
    }

   
}
