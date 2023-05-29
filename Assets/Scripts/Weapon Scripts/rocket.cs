using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class rocket : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject explosion;
    public GameObject ExplosionAudio;
    private Rigidbody rb;
    private double startVelocity;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        startVelocity = rb.velocity.magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.velocity.magnitude <= startVelocity * 0.7)
        {
            Explode();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            Explode();
        }
        //if (other.gameObject.layer == 3)
        //{
        //    Explode();
        //}
        if (other.gameObject.tag == "CrystalBoss")
        {
            Explode();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "CrystalBoss")
        {
            Explode();
        }
    }

    public void Explode()
    {
        ExplosionAudio.transform.parent = null;
        ExplosionAudio.SetActive(true);

        GameObject.Instantiate(explosion, this.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


 


}
