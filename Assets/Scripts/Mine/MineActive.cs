using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineActive : MonoBehaviour
{
    [SerializeField] private int _damage = 2;
    [SerializeField] private float _destroytime = 3f;
    // Start is called before the first frame update
    

    // Update is called once per frame
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            var peter = collision.gameObject.GetComponent<PlayerHelth>();
            peter.Damage(_damage);
            Destroy(gameObject, _destroytime);

        }
    }
}
