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

                    Debug.Log("Ajto nyitashoz kerem nyomja meg a (e) gombot!");
                    benneAll = true;

                }
                else { Debug.Log("SzÅEsÈges a s·rga kulcs az ajto kinyit·s·hoz!"); }
            }
            else if (gameObject.name == "kek_lada")
            {
                if (charinfo.keyK)
                {
                    Debug.Log("L·da kinyit·s·hoz kÈrem nyomja meg a (e) gombot!");
                    benneAll = true;

                }
                else { Debug.Log("SzÅEsÈges a kÈk kulcs a l·da kinyit·s·hoz!"); }
            }
            else if (gameObject.name == "zold_lada")
            {
                if (charinfo.keyZ)
                {
                    Debug.Log("L·da kinyit·s·hoz kÈrem nyomja meg a (e) gombot!");
                    benneAll = true;

                }
                else { Debug.Log("SzÅEsÈges a zˆld kulcs a l·da kinyit·s·hoz!"); }
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        textUGUI.text = " ";
        benneAll = false;
        //canvas szoveg eltuntetese
    }

    private void OnDestroy()
    {
        textUGUI.text = " ";
    }
}
