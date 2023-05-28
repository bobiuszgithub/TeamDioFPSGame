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
    float Timer = .0f;
    float TimeToThrow = 0.8f;
    private bool Thrown = false;






    public TextMeshProUGUI textUGUI;


    private AudioSource soundeffect;

    private void Start()
    {
        animator = GetComponent<Animator>();
        bullets = bulletCount;
        soundeffect = GetComponent<AudioSource>();

        textUGUI.text = $"Grenade\n{bullets}/{bulletCount.ToString()}";

    }
    private void Update()
    {
        textUGUI.text = $"Grenade\n{bullets}/{bulletCount.ToString()}";
        if (Thrown)
        {
            Timer += 1 * Time.deltaTime;
            if (Timer >= TimeToThrow)
            {
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, shellRotation.transform.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
                bullets--;
                textUGUI.text = $"Grenade\n{bullets}/{bulletCount.ToString()}";
                if (bullets == 0)
                {
                    lockTime = DateTime.Now;
                }
                Thrown = false;
                Timer = .0f;
            }
        }
      
       
        if (bullets > 0 && !canvas.isActiveAndEnabled)//
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                soundeffect.Play();
                animator.SetTrigger("Throw");
                Thrown = true;
                             
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
                    textUGUI.text = $"Grenade\n{bullets}/{bulletCount.ToString()}";
                }
                
            }



        }


    }
}
