using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBetweenAandB : MonoBehaviour
{
    public GameObject TargetPosition;
    public float speed = 1.0f;

    private Vector3 pos1;
    private Vector3 pos2;

    private void Start()
    {
        pos1 = transform.position;
        pos2 = TargetPosition.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.Lerp(pos1, pos2, Mathf.PingPong(Time.time * speed, 1.0f));
    }
}
