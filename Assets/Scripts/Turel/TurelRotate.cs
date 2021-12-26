using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurelRotate : MonoBehaviour
{    [SerializeField] private Transform _target;
     [SerializeField] private float _speed;
     [SerializeField] private float _distanceToTarget;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update()
    {
        Vector3 targetDir = _target.position-transform.position;//определяем текущий вектор до цели
                                                                // Vector3 newDir = Vector3.RotateTowards(transform.position, targetDir, _speed * Time.deltaTime,0.2f);
                                                                //Debug.DrawRay(transform.position, newDir, Color.green);
       
        Debug.Log(targetDir.sqrMagnitude);
        Debug.Log(_distanceToTarget);
        if (targetDir.sqrMagnitude <= (_distanceToTarget * _distanceToTarget))
        {   //transform.rotation = Quaternion.LookRotation(newDir);
            transform.LookAt(_target.position);
        }

    }

    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.gameObject.CompareTag("Player"))
    //    {
           
    //        //
    //        //var peter = collision.gameObject.GetComponent<PlayerHelth>();
    //        //peter.Damage(_damage);
    //        //Destroy(gameObject, _destroytime);

    //    }
    //}
}
