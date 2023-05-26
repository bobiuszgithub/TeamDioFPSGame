using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DoorOpening : MonoBehaviour
{

    public int monsterCount;

    private Animator animator;

    private bool animationplayed;

    public GameObject PeaceLight;
    public GameObject FightLight;


    void Start()
    {
   
        animator = GetComponent<Animator>();
        animationplayed = false;     

    }

    // Update is called once per frame
    void Update()
    {
        if (monsterCount == 0 && !animationplayed)
        {
            animator.SetTrigger("OpenDoor");
            animationplayed = true;
            if (PeaceLight != null)
            {
                PeaceLight.SetActive(true);
            }
            if (FightLight != null)
            {
                FightLight.SetActive(false);
            }
        }
    }


}
