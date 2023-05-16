using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySighting : MonoBehaviour
{
    public GameObject Enemy;
    private enemy EnemyInfo;
    // Start is called before the first frame update
    void Start()
    {
        EnemyInfo = Enemy.GetComponent<enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" ||other.gameObject.tag == "Bullet")
        {
            
            EnemyInfo.PlayerinSight = true;
        }
        
    }
}
