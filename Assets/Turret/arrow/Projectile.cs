using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    [SerializeField] float projectileSpeed = 5;

    private void Update()
    {
        transform.Translate(new Vector3(0f,0f,projectileSpeed * Time.deltaTime));
    }
}
