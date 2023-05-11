using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EDoor : MonoBehaviour
{
    public GameObject Door;
    private DoorOpening room;

    private enemy enemyInfo;

    void Start()
    {
        room = Door.GetComponent<DoorOpening>();
        room.monsterCount++;
        enemyInfo = GetComponent<enemy>();

    }

  
    void Update()
    {

    }


    private void OnDestroy()
    {
        room.monsterCount--;
    }
}
