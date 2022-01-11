using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{
    [SerializeField] private float _speed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _playerForce;
    [SerializeField] private MoverLaser _prefabBulet;
    [SerializeField] private Transform _buletPlayerStartPoint;
    private Vector3 _direction;
    public bool isOnGround;
    private Rigidbody _rigibodyPlayer;


    private void OnCollisionEnter(Collision other)

    {
        if (other.gameObject.CompareTag("floor"))
        {
            isOnGround = true;
        }
    }

    // Update is called once per frame
    private void Update()

    {   
        _direction.x=Input.GetAxis("Horizontal");
        _direction.z= Input.GetAxis("Vertical");
        _direction.Normalize();

        var speed = (_direction.sqrMagnitude > 0) ? _speed : 0;
        speed = speed * Time.deltaTime;
        transform.position = transform.position + transform.forward * speed;
        Vector3 desiredForward = Vector3.RotateTowards(transform.forward, _direction, _rotateSpeed * Time.deltaTime, 0f);//находим новый вектор для поворота
        transform.rotation = Quaternion.LookRotation(desiredForward);//поворачиваем обьект на заданный вектор

        Fire();
        Jump();

    }  

    private void Fire()//выстрел кнопкой "left ctrl"
    {
        if (Input.GetButtonDown("Fire1"))
        {
            MoverLaser bomb= Instantiate(_prefabBulet, _buletPlayerStartPoint.position, _buletPlayerStartPoint.rotation);
            bomb.Launch(_playerForce);
        }   


    }

    private void Jump()//прыжок кнопкой "j"
    { 
        if(Input.GetButtonDown("Jump") && isOnGround)
        {
            isOnGround = false;
            _rigibodyPlayer = GetComponent<Rigidbody>();
            _rigibodyPlayer.AddForce(new Vector3(0, 5000, 0));
            
        }
    
    
    }

   

}
