using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float life = 1;
    float Timer = .0f;
    float DestroyBullet = 10.0f;
    public Bullet()
    {
        
    }


    private void Update()
    {
        Timer += 1 * Time.deltaTime;
        if (Timer >= DestroyBullet)
        {
        
            Destroy(gameObject);

        }
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
