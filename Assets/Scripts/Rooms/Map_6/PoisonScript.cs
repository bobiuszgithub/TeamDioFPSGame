using UnityEngine;

public class PoisonScript : MonoBehaviour
{
    public GameObject player;

    private CharacterInfo characterInfo;
    float Timer = .0f;
    float TimeToDamage = 3.0f;

    bool PoisonTouched = false;

    void Start()
    {
        characterInfo = player.GetComponent<CharacterInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += 1 * Time.deltaTime;
        if (PoisonTouched)
        {
            if (Timer >= TimeToDamage)
            {
                PlayerDamage();
                TimeToDamage += 2.0F;
            }
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            PoisonTouched = true;

        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PoisonTouched = false;

        }
    }

    

    private void PlayerDamage()
    {
        characterInfo.HP -= 5F;
    }
}
