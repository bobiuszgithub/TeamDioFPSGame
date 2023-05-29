using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public GameObject pausemenu;


    public GameObject OptionCanvas;
    void Start()
    {
        OptionCanvas.SetActive(false);
        pausemenu.SetActive(false);
        Time.timeScale = 1;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        megnyit();
    }
    void megnyit()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
           
            pausemenu.SetActive(true);
            Time.timeScale = 0;

            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
    }
    public void ResumeGame()
    {
       

        pausemenu.SetActive(false);
        Time.timeScale = 1;
        
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
       
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene("startGame");
    }


    public void Options()
    {
        pausemenu.SetActive(false);
        OptionCanvas.SetActive(true);

      
        
    }


    public void backToPause()
    {
        pausemenu.SetActive(true);
        OptionCanvas.SetActive(false);
    }

}
