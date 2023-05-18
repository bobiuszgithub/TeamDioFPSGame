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

    private bool shooting = false;


    public Canvas canvas;
    private Animator animator;

    public TextMeshProUGUI textUGUI;
    // private AudioSource soundeffect;




    float Timer = .0f;
    float TimeToDamage = 0.2f;

    float ReloadTimer = .0f;
    float ReloadTime = 1f;
    private bool Reload = false;


    private void Start()
    {
        //soundeffect = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        bullets = bulletCount;

        textUGUI.text = $"{bullets}/{bulletCount}";


    }

    private void Update()
    {
        textUGUI.text = $"{bullets}/{bulletCount}";



        if (Input.GetButtonDown("Fire1") && bullets > 0 && !canvas.isActiveAndEnabled)
        {

            shooting = true;

        }
        if (Input.GetButtonUp("Fire1"))
        {
            shooting = false;
        }

        if (bullets <= 0)
        {
            shooting = false;
        }

        if (shooting)
        {
            Timer += 1 * Time.deltaTime;
            if (Timer >= TimeToDamage)
            {
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, shellRotation.transform.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
                bullets--;
                textUGUI.text = $"{bullets}/{bulletCount}";
                Timer = .0f;
            }



        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            Reload = true;
        }

        if (Reload)
        {
            ReloadTimer += 1 * Time.deltaTime;
            if (ReloadTimer >= ReloadTime)
            {
                bullets = bulletCount;
                textUGUI.text = $"{bullets}/{bulletCount.ToString()}";
                Reload = false;
                ReloadTimer = .0f;
            }
        }

    



    }




}
