using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class menu : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void startGame()
    {
        SceneManager.LoadScene("CutScene01");

    }

    public void Exit()
    {
        Application.Quit();
        
    }
    public void Return()
    {
        SceneManager.LoadScene("Menu");

    }


    public void Options()
    {
        SceneManager.LoadScene("Information");

    }

}
