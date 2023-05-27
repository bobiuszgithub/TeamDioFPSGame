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


    private AudioSource soundeffect;
    public AudioClip Slice;


    void Start()
    {
        soundeffect = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

      


        textUGUI.text = "Sword";
        if (Input.GetKeyDown(KeyCode.Mouse0) && !canvas.isActiveAndEnabled)
        {

            soundeffect.clip = Slice;
            soundeffect.Play();
            animator.SetTrigger("Slice");


        }
    }


  

}
