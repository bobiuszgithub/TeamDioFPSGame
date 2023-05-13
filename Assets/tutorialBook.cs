using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tutorialBook : MonoBehaviour
{
    
    public GameObject ClosedBook;
    public GameObject OpenedBook;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            ClosedBook.SetActive(false);
            OpenedBook.SetActive(true);
        }
    }
}
