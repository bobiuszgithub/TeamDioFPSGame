using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Timeline;
using UnityEditor.UI;
using UnityEngine;

public class Turret : MonoBehaviour
{
    public GameObject target;
    private float fireRate = 1.5f;
    private bool hasLineOfSight;
    private bool canShoot = true;
    private Ray scan;

    private Gun currentGun;

    void Start()
    {
        currentGun = GetComponentInChildren<Gun>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerDirection = target.transform.position - transform.position;
        float turretRotationStep = 100 * Time.deltaTime;
        Vector3 newLookDirection = Vector3.RotateTowards(transform.forward, playerDirection, turretRotationStep, 0f);
        transform.rotation = Quaternion.LookRotation(newLookDirection);

        scan = new Ray(this.transform.position, target.transform.position - this.transform.position);
        RaycastHit hit;
        if (Physics.Raycast(scan, out hit))
        {
            if (hit.collider.tag == "Player")
            {
                hasLineOfSight = true;
            }
        }
        if (hasLineOfSight && canShoot)
        {
            currentGun.Fire();
            canShoot = false;
            Invoke(nameof(ResetCanShoot), fireRate);
        }
    }

    private void ResetCanShoot()
    {
        canShoot = true;
    }
}
