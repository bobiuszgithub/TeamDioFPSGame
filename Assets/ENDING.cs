using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENDING : MonoBehaviour
{
    public GameObject Boss;
    public GameObject diploma;
    private enemy enemyScript;
    void Start()
    {
        enemyScript = Boss.GetComponent<enemy>();
    }

    // Update is called once per frame
    void Update()
    {
        if (enemyScript.EnemyHp <= 0)
        {
            diploma.SetActive(true);
        }
    }
}
