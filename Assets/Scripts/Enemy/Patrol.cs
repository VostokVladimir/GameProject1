using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;


public class Patrol : MonoBehaviour
{
    [SerializeField] private Transform [] _target;
    
    private NavMeshAgent _agent;

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        var destination=_target[Random.RandomRange (0,_target.Length)];
        if(!_agent.pathPending && _agent.remainingDistance <=0.5f)
        {
            _agent.destination = destination.position;

        }
    }
}
