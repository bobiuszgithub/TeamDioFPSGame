using System;
using TMPro;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public Transform bulletSpawnPoint2;

    public GameObject shellRotation;



    public Canvas MuzzleFlash;

    public GameObject bulletPrefab;


    public float bulletspeed = 10;
    public int bulletCount;
    public float timeRemaining = 10;

    private int bullets;

    private DateTime lockTime;
    public Canvas canvas;
    private Animator animator;

    public TextMeshProUGUI textUGUI;
    public GameObject Player;
    private AudioSource soundeffect;
    public AudioClip ReloadSound;
    public AudioClip ShootSound;
    private void Start()
    {
        soundeffect = Player.GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        bullets = bulletCount;
        MuzzleFlash.enabled = false;

        textUGUI.text = $"Shotgun\n{bullets}/{bulletCount.ToString()}";

    }
    private void Update()
    {
        textUGUI.text = $"Shotgun\n{bullets}/{bulletCount.ToString()}";
        if (animator.GetCurrentAnimatorStateInfo(0).IsName("shootShotgun"))
        {
            MuzzleFlash.enabled = false;
        }

        if (bullets > 0 && !canvas.isActiveAndEnabled)//
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                soundeffect.clip = ShootSound;
                soundeffect.Play();

                MuzzleFlash.enabled = true;
                animator.SetTrigger("shootShotgun");


                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, shellRotation.transform.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;

                var bullet2 = Instantiate(bulletPrefab, bulletSpawnPoint2.position, shellRotation.transform.rotation);
                bullet2.GetComponent<Rigidbody>().velocity = bulletSpawnPoint2.forward * bulletspeed;



                bullets--;
                textUGUI.text = $"Shotgun\n{bullets}/{bulletCount.ToString()}";
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
                    MuzzleFlash.enabled = false;
                    soundeffect.clip = ReloadSound;
                    soundeffect.Play();
                    animator.SetTrigger("Sreload");
                    bullets = bulletCount;
                    textUGUI.text = $"Shotgun\n{bullets}/{bulletCount.ToString()}";
                }

            }



        }


    }



}
