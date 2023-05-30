using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kulcsos_ajtok : MonoBehaviour
{
    private Animator animator;

    private bool animationplayed;

    public Light doorLight;

    public GameObject lakat;


    public AudioSource audioDoor;

    void Start()
    {
        animator = GetComponent<Animator>();
        animationplayed = false;
        if (doorLight != null)
        {
            doorLight.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (lakat==null &&!animationplayed)
        {
            audioDoor.Play();
            animator.SetTrigger("OpenDoor");
            animationplayed = true;
            if (doorLight != null)
            {
                
                doorLight.enabled = true;
            }
        }
    }
}
