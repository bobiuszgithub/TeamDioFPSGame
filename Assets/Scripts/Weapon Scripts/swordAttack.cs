using System;
using TMPro;
using UnityEngine;

public class swordAttack : MonoBehaviour
{
    // Start is called before the first frame update
    public Canvas canvas;
    private Animator animator;
    private DateTime lockTime;

    public TextMeshProUGUI textUGUI;


  


    void Start()
    {
        
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

      


        textUGUI.text = " ";
        if (Input.GetKeyDown(KeyCode.Mouse0) && !canvas.isActiveAndEnabled)
        {

            animator.SetTrigger("Slice");


        }
    }


  

}
