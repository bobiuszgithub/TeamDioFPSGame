using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Map5 : MonoBehaviour
{
    public GameObject teleport;
    public GameObject enemy;
    private NavMeshAgent mozgas;

    private enemy EnemyInfo;
    private bool StartCountDown;
    private bool elsoalkalom;



    float Timer = .0f;
    float TimeToDamage = 1.5f;


    void Start()
    {
        


        EnemyInfo = enemy.GetComponent<enemy>();
        mozgas = enemy.GetComponent<NavMeshAgent>();
        mozgas.enabled = false;

        StartCountDown = false;
        elsoalkalom = true;

    }


    void Update()
    {
        if (StartCountDown)
        {
            Timer += 1 * Time.deltaTime;
        }
      
        if (Timer >= TimeToDamage && elsoalkalom)
        {
            enemy.transform.position = teleport.transform.position;
            mozgas.enabled = true;
            EnemyInfo.PlayerinSight = true;
            elsoalkalom = false;
        }

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {         
            StartCountDown = true;
        }

    }

    
}