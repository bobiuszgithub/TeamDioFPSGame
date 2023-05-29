using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    public GameObject Room1;
    public GameObject Room2;
    public GameObject Room3;
    public GameObject Room4;
    public GameObject Room5;
    public GameObject Room6;
    public GameObject Room7;
    public GameObject Room8;
    public GameObject Shop;


    
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
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            characterController.enabled = false;
            player.transform.position = Room1.transform.position;

            characterController.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            characterController.enabled = false;
            player.transform.position = Room2.transform.position;

            characterController.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            characterController.enabled = false;
            player.transform.position = Room3.transform.position;

            characterController.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            characterController.enabled = false;
            player.transform.position = Room4.transform.position;

            characterController.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            characterController.enabled = false;
            player.transform.position = Room5.transform.position;

            characterController.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            characterController.enabled = false;
            player.transform.position = Room6.transform.position;

            characterController.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha7))
        {
            characterController.enabled = false;
            player.transform.position = Room7.transform.position;

            characterController.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha8))
        {
            characterController.enabled = false;
            player.transform.position = Room8.transform.position;

            characterController.enabled = true;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            characterController.enabled = false;
            player.transform.position = Shop.transform.position;

            characterController.enabled = true;
        }
    }
}
