using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class money : MonoBehaviour
{
    public GameObject player;
    public TextMeshProUGUI MoneyGui;
    private CharacterInfo charinfo;


    void Start()
    {
        charinfo = player.GetComponent<CharacterInfo>();
        
        
    }

    //private void OnCollisionEnter(Collision collision)
    //{
       
    //    if (collision.gameObject.name == "Player")
    //    {
    //        Debug.Log("valami t?rt?nt");
    //        charinfo.Money = charinfo.Money + 10;         
    //        MoneyGui.text = "Gold: " + charinfo.Money.ToString();
    //        Destroy(this);
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
          
            charinfo.Money = charinfo.Money + 10;
            MoneyGui.text = "Kreditek: " + charinfo.Money.ToString();
            Destroy(gameObject);
        }
    }
}
