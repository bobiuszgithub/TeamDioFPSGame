using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffinScript : MonoBehaviour
{


    public GameObject Koporso1;
    public GameObject Koporso2;
    public GameObject Koporso3;
    private Animator koporsoanim1;
    private Animator koporsoanim2;
    private Animator koporsoanim3;
    private bool PlayedOnce = false;
    private AudioSource CoffinSound1;
    private AudioSource CoffinSound2;
    private AudioSource CoffinSound3;

    // Start is called before the first frame update
    void Start()
    {
        CoffinSound1 = Koporso1.GetComponent<AudioSource>();
        CoffinSound2 = Koporso2.GetComponent<AudioSource>();
        CoffinSound3 = Koporso3.GetComponent<AudioSource>();




        koporsoanim1 = Koporso1.GetComponent<Animator>();
        koporsoanim2 = Koporso2.GetComponent<Animator>();
        koporsoanim3 = Koporso3.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !PlayedOnce)
        {
            PlayedOnce = true;
            CoffinSound1.Play();
            CoffinSound2.Play(); 
            CoffinSound3.Play(); 
            koporsoanim1.SetTrigger("open");
            koporsoanim2.SetTrigger("open");
            koporsoanim3.SetTrigger("open");
          
        }

    }
}
