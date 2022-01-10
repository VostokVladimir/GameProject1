using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RoboMove : MonoBehaviour

{
    #region "Fields"
    [SerializeField] private Transform _playerTarget;
    NavMeshAgent _agent;
    Animator anim;

    public List<Transform> wayPoint;
    public int currentWayPoint;
    public float speed=4;
    public bool _isplayerInZone = false;
    #endregion


    /// <summary>
    /// метод проверки Зоны на наличие плеера 
    /// </summary>
    /// <param name="_isplayerInZone"></param>
    /// <returns></returns>

    private bool CheckZone(bool _isplayerInZone)
    {
        float distanceToPlayer = Vector3.Distance(transform.position, _playerTarget.position);
        if(distanceToPlayer<30f)
        {
            Debug.Log("Плеер в зоне");
            _isplayerInZone = true;

        }
         if(distanceToPlayer > 30f)
        {
            _isplayerInZone = false;
            Debug.Log("Плеер вне зоны");
        }
        return _isplayerInZone;
    }

    /// <summary>
    /// метод  птарулирования зоны по трем точкам
    /// </summary>
    private void Patrol()
    {
        if (wayPoint.Count > 1 && _isplayerInZone == false)

        {



            if (currentWayPoint < wayPoint.Count)
            {

                _agent.SetDestination(wayPoint[currentWayPoint].position);
                float distance = Vector3.Distance(transform.position, wayPoint[currentWayPoint].position);
                if (distance > 25f)
                {
                   
                    //anim.SetFloat("Speed", speed);
                    //speed += Time.deltaTime * 7;
                }
                else if (distance <= 25f && distance >= 10f)

                {
                    
                    Vector3 direction2 = (wayPoint[currentWayPoint].position - transform.position).normalized;
                    Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction2.x, 0, direction2.z));
                    transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * 10);
                }
                else if (distance < 12f)
                {
                    
                    currentWayPoint++;

                }

            }
            else if (currentWayPoint == wayPoint.Count)
            {
                currentWayPoint = 0;
            }
        }
        if (wayPoint.Count > 1 && _isplayerInZone == true)//начинаем догонять Плеера если он попадает в поле зрения Патруля
        {
            _agent.SetDestination(_playerTarget.position);

            float distance = Vector3.Distance(transform.position, _playerTarget.position);
            if (distance >= 30f)
            {

                _isplayerInZone = false;
                _agent.SetDestination(wayPoint[currentWayPoint].position);
            }

        }
    }

    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        //anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
               
        _isplayerInZone=CheckZone(_isplayerInZone);
        Patrol();
    }
}
