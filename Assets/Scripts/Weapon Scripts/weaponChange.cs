using UnityEngine;

public class weaponChange : MonoBehaviour
{
    private int weapon = 0;
    public GameObject Sword;
    public GameObject Pistol;
    public GameObject CM9;
    public GameObject Shotgun;
    public GameObject MagicBall;





    private Animator SwordAnimator;


    // Start is called before the first frame update
    void Start()
    {
        SwordAnimator = Sword.GetComponent<Animator>();
        Sword.SetActive(false);
        Pistol.SetActive(false);
        CM9.SetActive(false);
        Shotgun.SetActive(false);
        MagicBall.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (!SwordAnimator.GetCurrentAnimatorStateInfo(0).IsName("sword"))
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                weapon++;
                if (weapon == 5)
                {
                    weapon = 0;
                }

            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                weapon--;
                if (weapon == -1)
                {
                    weapon = 5;
                }

            }
        }


        switch (weapon)
        {
            case 0:
                Sword.SetActive(true);
                Pistol.SetActive(false);
                CM9.SetActive(false);
                Shotgun.SetActive(false);
                MagicBall.SetActive(false);
                break;
            case 1:
                Pistol.SetActive(true);
                Sword.SetActive(false);
                CM9.SetActive(false);
                Shotgun.SetActive(false);
                MagicBall.SetActive(false);
                break;
            case 2:
                Sword.SetActive(false);
                Pistol.SetActive(false);
                CM9.SetActive(true);
                Shotgun.SetActive(false);
                MagicBall.SetActive(false);
                break;
            case 3:
                Sword.SetActive(false);
                Pistol.SetActive(false);
                CM9.SetActive(false);
                Shotgun.SetActive(true);
                MagicBall.SetActive(false);
                break;
            case 4:
                Sword.SetActive(false);
                Pistol.SetActive(false);
                CM9.SetActive(false);
                Shotgun.SetActive(false);
                MagicBall.SetActive(true);
                break;
            default:
                break;
        }

    }




}
