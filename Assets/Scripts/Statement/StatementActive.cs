using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatementActive : MonoBehaviour
{
    private int _quantityStatement=1;
    private float _destroytime = 1f;
    /// <summary>
    /// Метод прибавляет балы за собранные префабы Отчетов на сцене
    /// </summary>
    /// <param name="other"></param>// колайдер игрока является параметром
    public void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            var peter = other.gameObject.GetComponent <PlayerHelth> ();
            peter.PickUpStatement(_quantityStatement);
            Destroy(gameObject, _destroytime);
                
        }
    }

}
