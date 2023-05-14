using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DmgTarget : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetComponentInChildren<CharacterInfo>() != null)
        {
            collision.gameObject.GetComponentInChildren<CharacterInfo>().HP -= 15;
            Destroy(gameObject);
        }
    }
}
