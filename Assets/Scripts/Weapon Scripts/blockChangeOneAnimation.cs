using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blockChangeOneAnimation : MonoBehaviour
{

    public GameObject wpobject;
    private weaponChange wp;
    private Animator animator;
    public string animationName;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        wp = wpobject.GetComponent<weaponChange>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animator == null)
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                wp.weapon++;
                if (wp.weapon == 6)
                {
                    wp.weapon = 0;
                }

            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                wp.weapon--;
                if (wp.weapon == -1)
                {
                    wp.weapon = 6;
                }

            }
        }
        else if (!isPlaying(animator, animationName))
        {
            if (Input.GetAxis("Mouse ScrollWheel") > 0)
            {
                wp.weapon++;
                if (wp.weapon == 6)
                {
                    wp.weapon = 0;
                }

            }
            if (Input.GetAxis("Mouse ScrollWheel") < 0)
            {
                wp.weapon--;
                if (wp.weapon == -1)
                {
                    wp.weapon = 6;
                }

            }
        }
         
        

    }



    bool isPlaying(Animator anim, string stateName)
    {
        if (anim.GetCurrentAnimatorStateInfo(0).IsName(stateName) &&
                anim.GetCurrentAnimatorStateInfo(0).normalizedTime < 1.0f)
            return true;
        else
            return false;
    }

}
