using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class locks : MonoBehaviour
{
    private CharacterInfo charinfo;
    public GameObject player;
    public GameObject item;
    
    private bool benneAll;

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
            }          
        }
     

    }
    private void ellenorzesZ()
    {
        if (gameObject.name == "zold_lada" && benneAll)
        {
            if (charinfo.keyZ)
            {
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
                Destroy(gameObject);
            }
            benneAll = false;
        }

        if (gameObject.name == "kek_lada" && benneAll)
        {
            if (charinfo.keyK)
            {
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
            textUGUI.text = "Press e to interact";
            if (gameObject.name == "S_lakat")
            {
                if (charinfo.keyS)
                {

                    benneAll = true;

                }
                else { textUGUI.text = "Nem nyitható sárga kulcs nélkûl"; }
            }
            else if (gameObject.name == "K_lakat")
            {
                if (charinfo.keyK)
                {
                    benneAll = true;

                }
                else { textUGUI.text = "Nem nyitható kék kulcs nélkûl"; }
            }
            else if (gameObject.name == "zold_lada")
            {
                if (charinfo.keyZ)
                {
                    benneAll = true;

                }
                else { textUGUI.text = "Nem nyitható zõld kulcs nélkûl"; }
            }
            else if (gameObject.name == "kek_lada")
            {
                if (charinfo.keyK)
                {
                    benneAll = true;
                }
                else { textUGUI.text = "Nem nyitható kék kulcs nélkûl"; }
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
}
