using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{


    private Animator animator;
    // Start is called before the first frame update
    float Timer = .0f;
    float TimeToExplo = 1.0f;

    public Transform Rotate;

    public Canvas canvas;
    public GameObject explosion;




    private bool Exploded;
    void Start()
    {
        animator = GetComponent<Animator>();
        Exploded = false;
         
    }

    // Update is called once per frame
    void Update()
    {



        Timer += 1 * Time.deltaTime;

        if (Exploded)
        {
            Destroy(gameObject);
        }

       

        if (Timer >= TimeToExplo)
        {
            canvas.transform.rotation = Rotate.rotation;
            explosion.transform.rotation = Rotate.rotation;
            animator.SetTrigger("Explode");
            if (animator.GetCurrentAnimatorStateInfo(0).IsName("Explosion"))
            {
                Exploded = true;
            }
           
        }

       
    }

}

