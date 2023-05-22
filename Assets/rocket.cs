using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class rocket : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject explosion;

    private 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
        {
            GameObject.Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        if (other.gameObject.layer == 3)
        {
            GameObject.Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
    }



}
