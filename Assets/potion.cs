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

    private CharacterInfo characterInfo;
    void Start()
    {
        characterInfo = Player.GetComponent<CharacterInfo>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && characterInfo.HP < 100)
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
