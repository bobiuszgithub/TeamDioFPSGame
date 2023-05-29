using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ENDING : MonoBehaviour
{
    public GameObject Boss;
    public GameObject diploma;
    private enemy enemyScript;

    private Animator DegreeAnimator;
    public GameObject MainCamera;
    public GameObject SecondCamera;
    private bool startTimer = false;
    public bool MOVED = false;


    float Timer = .0f;
    float TimeTomove = 3f;

    void Start()
    {
        enemyScript = Boss.GetComponent<enemy>();
        DegreeAnimator = diploma.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            Timer += 1 * Time.deltaTime;

            if (Timer >= TimeTomove && !MOVED)
            {

                SecondCamera.SetActive(false);
                MainCamera.SetActive(true);
                
                MOVED = true;
            }
        }


        if (enemyScript.EnemyHp <= 0 && !startTimer)
        {
            diploma.SetActive(true);
            SecondCamera.SetActive(true);
            MainCamera.SetActive(false);
            DegreeAnimator.SetTrigger("DEGREE");
            startTimer = true;

        }
    }
}
