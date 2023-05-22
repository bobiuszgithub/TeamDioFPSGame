using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keys : MonoBehaviour
{
    private CharacterInfo charinfo;
    public GameObject player;
    void Start()
    {
        charinfo = player.GetComponent<CharacterInfo>();
       
    }

    // Update is called once per frame
    void Update()
    {

    }
   


    private void OnTriggerEnter(Collider other)
    {
       
       
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.name == "sarga_kulcs")
            {
                charinfo.keyS = true;
                Destroy(gameObject);
            }
            else if (gameObject.name == "kek_kulcs")
            {
                charinfo.keyK = true;
                Destroy(gameObject);
            }
            else if (gameObject.name == "zold_kulcs")
            {
                charinfo.keyZ = true;
                Destroy(gameObject);
            }
            
        }
    }

  
}
