using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2Event : MonoBehaviour
{
    public bool StartAnim;
    public Animator anim;
    private bool _playerInZone = false;

    // Start is called before the first frame update
    public void Door2EventAnimationClose()
    {
        Debug.Log("Дверь закрыта");
        StartAnim = false;
        anim.SetBool("Test", StartAnim);
    }

    public void Door2EventAnimationOpen()
    {
        Debug.Log("Дверь открыта");
    }

    void Start()
    {
        anim = GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            _playerInZone = true;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            _playerInZone = false;
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && _playerInZone == true)
        {
            StartAnim = !StartAnim;
            anim.SetBool("Test", StartAnim);

        }

    }
}
