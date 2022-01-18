using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelth : MonoBehaviour
{
    [SerializeField] private int _health = 4;
    [SerializeField] private int _scoreStatement = 0;

    public void Damage(int damage)
    {
      _health = _health - damage;
        if (_health==0)
        {
            Destroy(gameObject);
            Debug.Log("Питер убит");
        }
    }

    public void PickUpStatement (int _quantityStatement)
    {
        _scoreStatement = _scoreStatement + _quantityStatement;


    }
}
