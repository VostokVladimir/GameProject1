using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class СamerControler : MonoBehaviour
{ //контролер камеры добавлено изменение
    [SerializeField]private GameObject _gameObject;
    private Vector3 _cameraDistance;

    // Start is called before the first frame update
    void Start()
    {
        _cameraDistance = transform.position - _gameObject.transform.position; 
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = _gameObject.transform.position + _cameraDistance;
    }
}
