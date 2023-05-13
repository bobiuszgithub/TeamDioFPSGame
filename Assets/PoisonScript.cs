using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoisonScript : MonoBehaviour
{
    public GameObject player;

    private CharacterInfo characterInfo;


    void Start()
    {
        characterInfo = player.GetComponent<CharacterInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            InvokeRepeating(nameof(PlayerDamage), 0.5f, 300);

        }
        
    }

    private void OnTriggerExit(Collider other)
    {
        CancelInvoke(nameof(PlayerDamage));
    }

    private void PlayerDamage()
    {
        characterInfo.HP -= 5F;
    }
}
