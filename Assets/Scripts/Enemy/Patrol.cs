using System.Collections;
using System.Collections.Generic;
using UnityEngine.AI;
using UnityEngine;


public class Patrol : MonoBehaviour
{
    [SerializeField] private Transform [] _targets;
    [SerializeField] private float speed;
    private NavMeshAgent _agent;

    private void Patroling()
    {
            var destination=_targets[Random.RandomRange (0,_targets.Length)];
            //Debug.Log(destination);
            //Debug.Log(_agent.remainingDistance);

            if(!_agent.pathPending && _agent.remainingDistance <=5f)
            {
              _agent.destination = destination.position*Time.deltaTime*speed;
              

            }

      
    }


    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();

    }

    // Update is called once per frame
    void Update()
    {
        Patroling();           


    }
}
