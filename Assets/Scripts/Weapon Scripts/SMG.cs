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


    public Canvas MuzzleFlash;

    public Canvas canvas;
    private Animator animator;

    public TextMeshProUGUI textUGUI;
    // private AudioSource soundeffect;



    public GameObject Player;
    private AudioSource soundeffect;
    public AudioClip ReloadSound;
    public AudioClip ShootSound;




    float Timer = .0f;
    float TimeToDamage = 0.2f;

    float ReloadTimer = .0f;
    float ReloadTime = 1f;
    private bool Reload = false;


    private void Start()
    {
        soundeffect = Player.GetComponent<AudioSource>();

        animator = GetComponent<Animator>();
        bullets = bulletCount;
        MuzzleFlash.enabled = false;
        textUGUI.text = $"SMG\n{bullets}/{bulletCount}";

        shooting = false;


    }

    private void Update()
    {
        textUGUI.text = $"SMG\n{bullets}/{bulletCount}";



        if (Input.GetButtonDown("Fire1") && bullets > 0 && !canvas.isActiveAndEnabled)
        {

            shooting = true;
            soundeffect.clip = ShootSound;
            soundeffect.Play();
        }
        if (Input.GetButtonUp("Fire1"))
        {
            shooting = false;
            MuzzleFlash.enabled = false;
            soundeffect.Stop();
        }

        if (bullets <= 0)
        {
            soundeffect.clip = null;
            
            shooting = false;
            MuzzleFlash.enabled = false;
        }

        if (shooting)
        {
            Timer += 1 * Time.deltaTime;
       
            if (Timer >= TimeToDamage)
            {
                animator.SetTrigger("SHOOT");
                MuzzleFlash.enabled = true;
               
                var bullet = Instantiate(bulletPrefab, bulletSpawnPoint.position, shellRotation.transform.rotation);
                bullet.GetComponent<Rigidbody>().velocity = bulletSpawnPoint.forward * bulletspeed;
                bullets--;
                textUGUI.text = $"SMG\n{bullets}/{bulletCount}";
                Timer = .0f;
  
            }

        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            soundeffect.clip = ReloadSound;
            soundeffect.Play();
            Reload = true;
            animator.SetTrigger("RELOAD");
        }

        if (Reload)
        {
            MuzzleFlash.enabled = false;
            ReloadTimer += 1 * Time.deltaTime;

            if (ReloadTimer >= ReloadTime)
            {


                bullets = bulletCount;
                textUGUI.text = $"SMG\n{bullets}/{bulletCount.ToString()}";
                Reload = false;
                ReloadTimer = .0f;
            }
        }

    



    }




}
