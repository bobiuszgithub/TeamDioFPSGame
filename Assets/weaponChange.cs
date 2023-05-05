using UnityEngine;

public class weaponChange : MonoBehaviour
{
    private int weapon = 0;
    public GameObject Sword;
    public GameObject Pistol;
    public GameObject CM9;
    public GameObject Shotgun;


    private bool unlockedWeapon1;
    private bool unlockedWeapon2;
    private bool unlockedWeapon3;
    private bool unlockedWeapon4;


    // Start is called before the first frame update
    void Start()
    {
        Sword.SetActive(false);
        Pistol.SetActive(false);
        CM9.SetActive(false);
        Shotgun.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
   
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            weapon++;
            if (weapon == 6)
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
        Debug.Log(weapon);

        switch (weapon)
        {
            case 0:
                Sword.SetActive(false);
                Pistol.SetActive(false);
                CM9.SetActive(false);
                Shotgun.SetActive(false);
                break;
            case 1:
                Sword.SetActive(true);
                Pistol.SetActive(false);
                CM9.SetActive(false);
                Shotgun.SetActive(false);
                break;
            case 2:
                Pistol.SetActive(true);
                Sword.SetActive(false);
                CM9.SetActive(false);
                Shotgun.SetActive(false);
                break;
            case 3:
                Sword.SetActive(false);
                Pistol.SetActive(false);
                CM9.SetActive(true);
                Shotgun.SetActive(false);
                break;
            case 4:
                Sword.SetActive(false);
                Pistol.SetActive(false);
                CM9.SetActive(false);
                Shotgun.SetActive(true);
                break;
            default:
                break;
        }

    }
}
