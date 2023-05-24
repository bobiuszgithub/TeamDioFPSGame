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

    private 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        Timer += 1 * Time.deltaTime;
        if (Timer >= TimeToExplo)
        {
            GameObject.Instantiate(explosion, this.transform.position, Quaternion.identity);
            Destroy(gameObject);

        }
    }




}
