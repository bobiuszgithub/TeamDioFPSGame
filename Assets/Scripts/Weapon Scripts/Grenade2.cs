using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class Grenade2 : MonoBehaviour
{
    // Start is called before the first frame update
    float Timer = .0f;
    float TimeToExplo = 2.0f;
    public GameObject explosion;
    public GameObject ExplosionAudio;


    
    private AudioSource audioS;
    public AudioClip audioC;

    private
    void Start()
    {
        audioS = GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {


        Timer += 1 * Time.deltaTime;
        if (Timer >= TimeToExplo)
        {
            ExplosionAudio.transform.parent = null;
            ExplosionAudio.SetActive(true);


            GameObject.Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3)
        {
            audioS.clip = audioC;
            audioS.Play();
        }
    }

}
