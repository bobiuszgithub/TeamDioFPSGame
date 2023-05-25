using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keys : MonoBehaviour
{
    private CharacterInfo charinfo;
    public GameObject player;


    public Image Silhouette;
    public Sprite Key;

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
                Silhouette.sprite = Key;
                charinfo.keyS = true;
                Destroy(gameObject);
            }
            else if (gameObject.name == "kek_kulcs")
            {
                Silhouette.sprite = Key;
                charinfo.keyK = true;
                Destroy(gameObject);
            }
            else if (gameObject.name == "zold_kulcs")
            {
                Silhouette.sprite = Key;
                charinfo.keyZ = true;
                Destroy(gameObject);
            }
            
        }
    }

  
}
