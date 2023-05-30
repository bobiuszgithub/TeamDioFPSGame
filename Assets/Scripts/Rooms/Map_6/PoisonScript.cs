using UnityEngine;

public class PoisonScript : MonoBehaviour
{
    public GameObject player;

    private CharacterInfo characterInfo;
    float Timer = .0f;
    float TimeToDamage = 3.0f;

    bool PoisonTouched = false;

    public AudioSource PoisonSplash;

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

            }
        }

    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PoisonSplash.Play();
            var hp = characterInfo.HP;
            characterInfo.HP = hp;
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
        Timer = .0f;
    }
}
