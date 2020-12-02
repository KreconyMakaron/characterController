using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using UnityEngine;
using UnityEngine.Video;

public class Door : MonoBehaviour
{
    public Transform door;
    public Transform closepos;
    public Transform openpos;

    public bool open = false;
    public float speed = 3f;

    void Start()
    {
        door.transform.position = closepos.transform.position;
    }

    void Update()
    {
        if (open && Vector3.Distance(door.position, openpos.position) > 0.001f)
        {
            door.position = Vector3.MoveTowards(door.position, openpos.position, speed * Time.deltaTime);
        }
        if (!open && Vector3.Distance(door.position, closepos.position) > 0.001f)
        {
            door.position = Vector3.MoveTowards(door.position, closepos.position, speed * Time.deltaTime);
        }
    }

    public void OpenClose()
    {
        open = !open;
    }
}
