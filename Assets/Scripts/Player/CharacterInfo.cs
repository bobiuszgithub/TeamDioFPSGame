using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CharacterInfo : MonoBehaviour
{
    public int Money;
    public float HP = 100;
    public float CurrentHP;

    public TextMeshProUGUI MoneyGui;
    public TextMeshProUGUI HPtext;
    public Slider jatekoselete;

    public bool keyS;
    public bool keyK;
    public bool keyZ;

    private AudioSource audioS;

    void Start()
    {
        jatekoselete.value = HP;
        MoneyGui.text = "Credits: " + Money.ToString();
        HPtext.text = HP.ToString();
        keyS=false; keyK=false; keyZ=false;
        CurrentHP = HP;

        audioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        jatekoselete.value = HP;
        HPtext.text = HP.ToString();


        if (HP < CurrentHP)
        {
            audioS.Play();
            CurrentHP = HP;
        }

    }

    //private void OnCollisionEnter(Collision collision)
    //{
        //if (collision.gameObject.tag == "Money")
        //{
        //    Money = Money + 10;

        //    Debug.Log(jatekoselete.value);
        //    MoneyGui.text = "Kreditek: " + Money.ToString();
        //    Destroy(collision.gameObject);
        //}
        //if (collision.gameObject.tag == "Enemy")
        //{
        //    HP = HP - 10;
        //    jatekoselete.value = HP;
        //    HPtext.text = HP.ToString();

        //}

       


    //}


}
