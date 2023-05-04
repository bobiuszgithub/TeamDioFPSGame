using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{

    
    public GameObject portal2;
    public GameObject player;
    private CharacterController characterController;
    

    // Start is called before the first frame update
    void Start()
    {
        characterController = player.GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            characterController.enabled = false;
            player.transform.position = portal2.transform.position;
            characterController.enabled = true;
        }
    }
}
