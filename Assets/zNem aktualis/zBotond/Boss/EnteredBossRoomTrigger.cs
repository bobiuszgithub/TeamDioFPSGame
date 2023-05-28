using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnteredBossRoomTrigger : MonoBehaviour
{
    [SerializeField] BossLogic bossScript;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (bossScript != null)
            {
                bossScript.PlayerEnteredRoom();
            }
           
        }
    }
}
