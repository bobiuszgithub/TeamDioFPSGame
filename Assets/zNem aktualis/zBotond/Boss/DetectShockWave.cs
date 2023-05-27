using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectShockWave : MonoBehaviour
{

    public CharacterInfo characterInfo;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "ShockWave")
        {
            characterInfo.HP -= 15;
        }
        else if (other.gameObject.tag == "RotatingWall")
        {
            if (other.gameObject.GetComponentInParent<WallHandler>().canDmg)
            {
                characterInfo.HP -= 15;
            }
        }
        else if (other.gameObject.tag == "Lava")
        {
            characterInfo.HP = 0;
        }
    }
}
