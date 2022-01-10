using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverBulet : MonoBehaviour
{
    public float Speed;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.position= transform.position+transform.right*Time.deltaTime * Speed;//постоянно пуля летит кудато вбок 
        //var direction = pointB.position - transform.position;
        //transform.Translate(direction * Time.deltaTime * Speed);
        
    }
}
