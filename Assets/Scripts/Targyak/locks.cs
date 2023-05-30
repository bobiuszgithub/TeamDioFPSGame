using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class locks : MonoBehaviour
{
    private CharacterInfo charinfo;
    public GameObject player;
    public GameObject item;
    
    private bool benneAll;

    public GameObject Sound;

    public TextMeshProUGUI textUGUI;
    void Start()
    {
        charinfo = player.GetComponent<CharacterInfo>();
        benneAll = false;
    }


    void Update()
    {



        if (benneAll)
        {       
            if (Input.GetKeyUp("e"))
            {
                
                ellenorzesS();
                ellenorzesK();
                ellenorzesZ();
                ellenorzesM1();
            }          
        }
     

    }

    private void ellenorzesM1()
    {
        if (gameObject.name=="mimic1" && benneAll)
        {
            item.SetActive(true);
            Destroy(gameObject);
        }
    }
    private void ellenorzesZ()
    {
        if (gameObject.name == "zold_lada" && benneAll)
        {
            if (charinfo.keyZ)
            {
                SoundParentDrop();
               item.SetActive(true);
                Destroy(gameObject);

            }
            benneAll = false;
        }
    }


    private void ellenorzesK()
    {
        if (gameObject.name == "K_lakat" && benneAll)
        {
            if (charinfo.keyK)
            {
                SoundParentDrop();
                Destroy(gameObject);
            }
            benneAll = false;
        }

        if (gameObject.name == "kek_lada" && benneAll)
        {
            if (charinfo.keyK)
            {
                SoundParentDrop();
                item.SetActive(true);
                Destroy(gameObject);                
            }
            benneAll = false;
        }
    }

    private void ellenorzesS()
    {
        if (gameObject.name == "S_lakat" && benneAll)
        {
            if (charinfo.keyS)
            {
                SoundParentDrop();
                Destroy(gameObject);

            }
            benneAll = false;
        }
    }


    private void OnTriggerStay(Collider other)
    {
       
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            textUGUI.text = "Press (e) to open";
            if (gameObject.name == "S_lakat")
            {
                if (charinfo.keyS)
                {

                    benneAll = true;

                }
                else { textUGUI.text = "The door cannot be opened without the yellow key"; }
            }
            else if (gameObject.name == "K_lakat")
            {
                if (charinfo.keyK)
                {
                    benneAll = true;

                }
                else { textUGUI.text = "The door cannot be opened without the blue key"; }
            }
            else if (gameObject.name == "zold_lada")
            {
                if (charinfo.keyZ)
                {
                    benneAll = true;

                }
                else { textUGUI.text = "The chest cannot be opened without the green key"; }
            }
            else if (gameObject.name == "kek_lada")
            {
                if (charinfo.keyK)
                {
                    benneAll = true;
                }
                else { textUGUI.text = "The chest cannot be opened without the blue key"; }
            }
            else if (gameObject.name=="mimic1")
            {
                benneAll = true;
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        textUGUI.text = " ";  //canvas szoveg eltuntetese
        benneAll = false;
      
    }

    private void OnDestroy()
    {
        textUGUI.text = " ";
    }



    private void SoundParentDrop()
    {
        Sound.transform.parent = null;
        Sound.SetActive(true);
    }
}
