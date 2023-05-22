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
            if (Input.GetKeyDown("y"))
            {
                ellenorzesS();

            }
            else if (Input.GetKeyDown("b"))
            {
                ellenorzesK();

            }
            else if (Input.GetKeyDown("g"))
            {
                ellenorzesZ();
            }
        }

    }
    private void ellenorzesZ()
    {
        if (gameObject.name == "Z_lakat")
        {
            if (charinfo.keyZ)
            {
                Destroy(gameObject);

            }
            else { Debug.Log("Szükséges a zöld kulcs!"); }

        }

        benneAll = false;
    }


    private void ellenorzesK()
    {
        if (gameObject.name == "K_lakat")
        {
            if (charinfo.keyK)
            {
                Destroy(gameObject);

            }
            else { Debug.Log("Szükséges a kék kulcs!"); }

        }
        benneAll = false;
    }

    private void ellenorzesS()
    {
        if (gameObject.name == "S_lakat")
        {
            if (charinfo.keyS)
            {
                Destroy(gameObject);

            }
            else { Debug.Log("Szükséges a sárga kulcs!"); }

        }
        benneAll = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        benneAll = true;
    }

    private void OnTriggerExit(Collider other)
    {
        benneAll = false;
        //canvas szoveg eltuntetese
    }
}
