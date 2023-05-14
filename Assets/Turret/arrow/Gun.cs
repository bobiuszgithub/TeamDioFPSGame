using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Gun : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] float rateOfFire;
    [SerializeField] float bonusShootHeight = 0.5f;

    public void Fire()
    {
        Vector3 ShootLocation = new Vector3(transform.position.x, transform.position.y + bonusShootHeight, transform.position.z);
        Instantiate(projectile, ShootLocation, transform.rotation);
    }
}
