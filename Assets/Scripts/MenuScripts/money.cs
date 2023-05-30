using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class money : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI MoneyGui;
    private CharacterInfo charinfo;


    public GameObject audioS;


    void Start()
    {

        
        charinfo = player.GetComponent<CharacterInfo>();
        
        
    }

   
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            audioS.SetActive(true);
            audioS.transform.parent = null;
           
          
            charinfo.Money = charinfo.Money + 10;
            MoneyGui.text = "Credits: " + charinfo.Money.ToString();
            Destroy(gameObject);
        }
    }
}
