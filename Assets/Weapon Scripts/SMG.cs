using System;
using TMPro;
using UnityEngine;

public class SMG : MonoBehaviour
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
        //soundeffect = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        bullets = bulletCount;

        textUGUI.text = $"{bullets}/{bulletCount.ToString()}";


    }

    private void Update()
    {


        if (bullets > 0 && !canvas.isActiveAndEnabled)//
        {

            if (Input.GetButtonDown("Fire1"))
            {

                while (bullets > 0)
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
                //soundeffect.Play();
                //animator.SetTrigger("shoot");

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

                    bullets = bulletCount;
                    textUGUI.text = $"{bullets}/{bulletCount.ToString()}";
                }
                //bullets = bulletCount;
                //textUGUI.text = $"{bullets}/{bulletCount.ToString()}";
            }



        }







    }




}
