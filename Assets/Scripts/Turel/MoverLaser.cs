using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverLaser : MonoBehaviour

{
    [SerializeField ]public float speed;
    // Start is called before the first frame update
    public void Start()
    {
        GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
