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



    // Start is called before the first frame update
    void Start()
    {
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
        if (other.gameObject.tag == "Player")
        {
            koporsoanim1.SetTrigger("open");
            koporsoanim2.SetTrigger("open");
            koporsoanim3.SetTrigger("open");
          
        }

    }
}
