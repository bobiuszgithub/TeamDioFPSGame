using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class AboveHeadSlapHandler : MonoBehaviour
{
    float currentspeed = -0.03f;

    // Start is called before the first frame update
    void Start()
    {
        Invoke(nameof(StartDeleted), 5f);
        transform.RotateAround(transform.position, transform.right, 180);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentLocation = transform.position;
        currentspeed = currentspeed + (Time.deltaTime * -0.03f);
        transform.position = new Vector3(0, currentspeed, 0) + currentLocation;
    }

    private void StartFalling()
    {

    }

    private void StartDeleted()
    {
        Destroy(gameObject);
    }


}
