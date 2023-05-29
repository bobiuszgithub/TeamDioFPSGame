using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullActivate : MonoBehaviour
{
    [SerializeField] GameObject NeededToActivate;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            NeededToActivate.SetActive(true);
            NeededToActivate.GetComponent<SkullRiseScript>().enabled = true;
            Destroy(this);
        }        
    }
}
