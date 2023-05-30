using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PuzzleScript : MonoBehaviour
{
    public GameObject platform;
    public TextMeshProUGUI textUGUI;


    public GameObject audioFalling;
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
            audioFalling.SetActive(true);
            textUGUI.text = "";
            Destroy(gameObject);
        }
       
    }
}
