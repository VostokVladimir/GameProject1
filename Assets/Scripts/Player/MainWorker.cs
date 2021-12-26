using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainWorker : MonoBehaviour
    {
      public int Number;
   // public Transform Position;
   // public GameObject PiterPrefab;
    public GameObject EnemyPrefab;
    public Transform PositionEnemy;

    private void Awake()
    {
       // var Peter = new GameObject();
       // Peter.transform.position = Position.position;
        //Peter.name = "Peter1";
    }

    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log(Number);
        //var g01=Instantiate(PiterPrefab, Position.position, Quaternion.identity);
        var g02 = Instantiate(EnemyPrefab, PositionEnemy.position, Quaternion.identity);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
       // Time.fixedDeltaTime;
    }

    void LateUpdate()
    {
        
    }

}
