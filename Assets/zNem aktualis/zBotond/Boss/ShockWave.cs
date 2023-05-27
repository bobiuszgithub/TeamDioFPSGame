using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class ShockWave : MonoBehaviour
{
    [SerializeField] float increaseSpeed = 1.0f;
    private float initializationTime;
    // Start is called before the first frame update
    void Start()
    {
        initializationTime = Time.timeSinceLevelLoad;
        Invoke(nameof(StartDestroy), 5f);
    }

    // Update is called once per frame
    void Update()
    {
        float timeSinceInitialization = Time.timeSinceLevelLoad - initializationTime;
        transform.localScale = new Vector3(50 * timeSinceInitialization * increaseSpeed, 50 * timeSinceInitialization * increaseSpeed, transform.localScale.z);
    }

    private void StartDestroy()
    {
        Destroy(gameObject);
    }

}
