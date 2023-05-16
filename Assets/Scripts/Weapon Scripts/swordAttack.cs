using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvas;
    private Animator animator;
    private DateTime lockTime;
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse0) && !canvas.isActiveAndEnabled)
        {
     
            animator.SetTrigger("Slice");
           

        }
    }
}
