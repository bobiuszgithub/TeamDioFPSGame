using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallHandler : MonoBehaviour
{
    [SerializeField] float roationSpeed = 10f;
    [SerializeField] float attackLenght = 7f;
    public bool canDmg = false;

    private void Start()
    {
        Invoke(nameof(StartDestroy), attackLenght);
        Invoke(nameof(StartCanDmg), 1f);
    }
    private void Update()
    {
        transform.RotateAround(transform.position, transform.up, Time.deltaTime * roationSpeed);
    }

    private void StartDestroy()
    {
        Destroy(gameObject);
    }

    private void StartCanDmg()
    {
        canDmg = true;
    }
}
