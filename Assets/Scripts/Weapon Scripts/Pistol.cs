using System;
using TMPro;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletspeed = 10;
    public int bulletCount;
    public float timeRemaining = 10;

    private int bullets;
    public GameObject shellRotation;

    public Canvas MuzzleFlash;



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

        textUGUI.text = $"Pistol\n{bullets}/{bulletCount.ToString()}";

    }
    private void Update()
    {
        textUGUI.text = $"Pistol\n{bullets}/{bulletCount.ToString()}";

        if (!animator.GetCurrentAnimatorStateInfo(0).IsName("shootPistol"))
        {
            MuzzleFlash.enabled = false;
        }


        if (bullets > 0 && !canvas.isActiveAndEnabled)//
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                MuzzleFlash.enabled = true;
                soundeffect.clip = ShootSound;
                soundeffect.Play();
                animator.SetTrigger("Shoot");
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, shellRotation.transform.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
                bullets--;
                textUGUI.text = $"Pistol\n{bullets}/{bulletCount.ToString()}";
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
                    soundeffect.clip = ReloadSound;
                    soundeffect.Play();
                    MuzzleFlash.enabled = false;
                    animator.SetTrigger("Reload");
                    bullets = bulletCount;
                    textUGUI.text = $"Pistol\n{bullets}/{bulletCount.ToString()}";
                }

            }



        }







    }




}
