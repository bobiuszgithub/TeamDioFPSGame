using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locks : MonoBehaviour
{
    private CharacterInfo charinfo;
    public GameObject player;
    private bool benneAll;

    void Start()
    {
        charinfo = player.GetComponent<CharacterInfo>();
        benneAll = false;
    }


    void Update()
    {

        if (benneAll)
        {
            if(Input.GetKeyUp("g"))
            {
                ellenorzesS();
                ellenorzesK();
                ellenorzesZ();
            }
            
        }

    }
    private void ellenorzesZ()
    {
        if (gameObject.name == "Z_lakat" && benneAll)
        {
            if (charinfo.keyZ)
            {
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


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (gameObject.name == "S_lakat")
            {
                if (charinfo.keyS)
                {
                    Debug.Log("Ajto nyitásához kérem nyomja meg a (g) gombot!");
                    benneAll = true;

                }
                else { Debug.Log("Szükséges a sárga kulcs az ajto kinyitásához!"); }
            }
           else if (gameObject.name == "K_lakat")
            {
                if (charinfo.keyK)
                {
                    Debug.Log("Ajto nyitásához kérem nyomja meg a (g) gombot!");
                    benneAll = true;

                }
                else { Debug.Log("Szükséges a kék kulcs az ajto kinyitásához!"); }
            }
            else if (gameObject.name == "Z_lakat")
            {
                if (charinfo.keyZ)
                {
                    Debug.Log("Ajto nyitásához kérem nyomja meg a (g) gombot!");
                    benneAll = true;

                }
                else { Debug.Log("Szükséges a zöld kulcs az ajto kinyitásához!"); }
            }

        }
    }

    private void OnTriggerExit(Collider other)
    {
        benneAll = false;
        //canvas szoveg eltuntetese
    }
}
