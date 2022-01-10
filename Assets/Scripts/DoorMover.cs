using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMover : MonoBehaviour
{
    private float anglOpen = 90;
    private float angClose = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
           transform.rotation=Quaternion.AngleAxis(anglOpen,Vector3.up);
        }
    }

    private void CloseDoor()
    {
      transform.rotation = Quaternion.AngleAxis(angClose, Vector3.up);
    }

    private void OnTriggerExit(Collider other)
    {  
        if (other.gameObject.CompareTag("Player"))
        {
            Invoke("CloseDoor", 8);//задержка закрывания двери
            
        }
    }




}
