using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class potion : MonoBehaviour
{
    public GameObject Player;
    public Slider hp;

    private bool benneAll;
    public TextMeshProUGUI textUGUI;

    private CharacterInfo characterInfo;
    void Start()
    {
        characterInfo = Player.GetComponent<CharacterInfo>();
        benneAll = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (benneAll)
        {
            if (Input.GetKeyUp("e"))
            {
                characterInfo.HP += 25;

                if (characterInfo.HP > 100)
                {
                    characterInfo.HP = 100;
                }
                hp.value = characterInfo.HP;

                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.tag== "Player")
        {
            if (characterInfo.HP < 100)
            {
                benneAll = true;
                textUGUI.text = "Press (e) to drink the potion!";
            }
            else
            {
                benneAll = false;
                textUGUI.text = "Your health bar is full, you cannot take this potion";
            }

        }
        


              
    }

    private void OnDestroy()
    {
        textUGUI.text = " ";
        benneAll = false;
    }


    private void OnTriggerExit(Collider other)
{
    textUGUI.text = " ";  //canvas szoveg eltuntetese
    benneAll = false;

}
}