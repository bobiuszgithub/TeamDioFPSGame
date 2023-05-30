using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BossCheck : MonoBehaviour
{
    public GameObject wall;

    private Animator wallAnim;

    public GameObject BOSS;
    private NavMeshAgent NAVMESH;

    public GameObject WallSmash;


    // Start is called before the first frame update
    void Start()
    {
        NAVMESH = BOSS.GetComponent<NavMeshAgent>();
        wallAnim = wall.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            WallSmash.SetActive(true);
            NAVMESH.enabled = true;
            wallAnim.SetTrigger("BREAK");
            Destroy(gameObject);
        }
    }
}
