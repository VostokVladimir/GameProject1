using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverLaser : MonoBehaviour
    //запуск гранаты 
{
   // [SerializeField ]public float speed;
    [SerializeField] public float _lifeTime;
    private Rigidbody _rigidbody;
   
    public void Launch(float force)
    {
        Destroy(gameObject, _lifeTime);
        _rigidbody = GetComponent<Rigidbody>();
        // GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().transform.forward * speed;
        var impulse = transform.up * _rigidbody.mass * force;
        _rigidbody.AddForce(impulse, ForceMode.Impulse);

    }

    
}
