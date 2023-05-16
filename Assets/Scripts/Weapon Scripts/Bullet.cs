using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 1;

    public Bullet()
    {
        
    }

    private void Awake()
    {
        Destroy(gameObject, life);
     
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
            Destroy(gameObject);
    }
}
