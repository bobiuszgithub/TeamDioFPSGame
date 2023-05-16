using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GrenadeWeapon : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletspeed = 10;
    public int bulletCount;
    public float timeRemaining = 10;

    private int bullets;
    public GameObject shellRotation;




    private DateTime lockTime;
    public Canvas canvas;
    private Animator animator;

    public TextMeshProUGUI textUGUI;
    // private AudioSource soundeffect;

    private void Start()
    {
        animator = GetComponent<Animator>();
        bullets = bulletCount;


        textUGUI.text = $"{bullets}/{bulletCount.ToString()}";

    }
    private void Update()
    {

      

        if (bullets > 0 && !canvas.isActiveAndEnabled)//
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
               
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, shellRotation.transform.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
                bullets--;
                textUGUI.text = $"{bullets}/{bulletCount.ToString()}";
                if (bullets == 0)
                {
                    lockTime = DateTime.Now;
                }
            }


        }
        else
        {
            DateTime most = DateTime.Now;
            int eredeti = lockTime.Second + lockTime.Minute * 60 + lockTime.Hour * 3600;
            int uj = most.Second + most.Minute * 60 + most.Hour * 3600;


            if (uj - eredeti > 1)
            {
                if (Input.GetKeyDown(KeyCode.R))
                {
                    //animator.SetTrigger("Reload");
                    bullets = bulletCount;
                    textUGUI.text = $"{bullets}/{bulletCount.ToString()}";
                }
                
            }



        }


    }
}
