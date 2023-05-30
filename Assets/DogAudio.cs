using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAudio : MonoBehaviour
{

    public GameObject audioS;
    public GameObject Enemy;
    private enemy enemyScript;
    void Start()
    {

        enemyScript = Enemy.GetComponent<enemy>();    
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript != null)
        {
            //Debug.Log(enemyScript.EnemyHp);
            if (enemyScript.PlayerinSight)
            {
                audioS.SetActive(true);
            }
        }

   
    }
}
