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
    private bool elsoAlkalom;

    void Start()
    {
        EnemyInfo = enemy.GetComponent<enemy>();
        mozgas = enemy.GetComponent<NavMeshAgent>();
        mozgas.enabled = false;

        elsoAlkalom = true;

    }


    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (elsoAlkalom)
            {
                elsoAlkalom = false;
                Invoke(nameof(Inditas), 6);
            }
        }

    }

    private void Inditas()
    {
        Debug.Log("alma");
        enemy.transform.position = teleport.transform.position;
        mozgas.enabled = true;
        EnemyInfo.PlayerinSight = true;
    }
}