using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotDestroyer : MonoBehaviour
{ //Уничтожение пуль турели при выходе из зоеы коллайдера объекта ShotZone

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Bulet"))
        {
            Destroy(other.gameObject);
        }
    }

}
