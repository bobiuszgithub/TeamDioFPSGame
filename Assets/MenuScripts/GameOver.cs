using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public GameObject GameoverCanvas;


    public GameObject PlayerInfo;
    private CharacterInfo info;
    public GameObject pausemenu;
    private Movement movement;
    public GameObject playerinfo2;
    private PauseMenu pause;
    void Start()
    {
        pause = playerinfo2.GetComponent<PauseMenu>();
        GameoverCanvas.SetActive(false);
        info = PlayerInfo.GetComponent<CharacterInfo>();
        movement = PlayerInfo.GetComponent<Movement>();
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        if (info.HP <= 0)
        {
            pause.enabled = false;
            movement.enabled = false;
            GameoverCanvas.SetActive(true);
            Time.timeScale = 0;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }


    public void Restart()
    {
        SceneManager.LoadScene("startGame");
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
}
