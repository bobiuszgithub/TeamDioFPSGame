using System;
using TMPro;
using UnityEngine;

public class gun : MonoBehaviour
{
    public Transform bulletSpawnPoint;
    public GameObject bulletPrefab;
    public float bulletspeed = 10;
    public int bulletCount = 3;
    public float timeRemaining = 10;

    private Animator animator;
    private DateTime lockTime;
    public Canvas canvas;


    public TextMeshProUGUI textUGUI;


    private void Start()
    {
        textUGUI.text = bulletCount.ToString();
        animator = GetComponent<Animator>();
    }
    private void Update()
    {

        if (bulletCount > 0 && !canvas.isActiveAndEnabled)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
                bulletCount--;
                textUGUI.text = Convert.ToString(bulletCount);
                if (bulletCount == 0)
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
                animator.SetTrigger("Re");
                bulletCount = 3;
                textUGUI.text = Convert.ToString(bulletCount);
            }



        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("Re");
            bulletCount = 3;
            textUGUI.text = Convert.ToString(bulletCount);
        }






    }
}
