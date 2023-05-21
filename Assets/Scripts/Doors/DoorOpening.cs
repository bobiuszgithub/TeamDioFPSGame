using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{

    public int monsterCount;

    private Animator animator;

    private bool animationplayed;

    public Light doorLight;


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
        if (monsterCount == 0 && !animationplayed)
        {
            animator.SetTrigger("OpenDoor");
            animationplayed = true;
            if (doorLight != null)
            {
                doorLight.enabled = true;
            }
        }
    }


}
