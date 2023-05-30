using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class water : MonoBehaviour
{


    public AudioSource audioS;

    public GameObject Turtle;
    private AudioSource TurtleSound;

    // Start is called before the first frame update
    void Start()
    {
       
        TurtleSound = Turtle.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
        
            
        
    }




    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" || other.gameObject.tag == "Bullet")
        {
            if (Turtle != null)
            {
                TurtleSound.enabled = true;
            }
            
            audioS.Play();
        }

    }



}
