using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    bool iCanOpen = false;
    public Door[] doors;
    public KeyColor myColor;
    public bool locked = false;
    Animator key;

    private void Start()
    {
        key = GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            iCanOpen = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            iCanOpen = false;
        }
    }

    public void Update()
    {
        
    }

    public void UseKey()
    {
        foreach (Door door in doors)
        {
            door.OpenClose();
        }
    }
}
