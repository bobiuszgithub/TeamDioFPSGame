using UnityEngine;
using UnityEngine.SceneManagement;

public class CoffinCutScene : MonoBehaviour
{
    private AudioSource soundeffect;
    private Animator coffinanimator;

    public GameObject Camera;
    private Animator cameraAnimator;
    public GameObject canvas;


    float Timer = .0f;
    float TimeTomove = 1f;
    public bool startTimer = false;
    public bool MOVED = false;
    public bool Pressed = false;





    float MapTimer = .0f;
    float ChangeMap = 3f;
    

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        soundeffect = GetComponent<AudioSource>();
        coffinanimator = GetComponent<Animator>();
        cameraAnimator = Camera.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (startTimer)
        {
            Timer += 1 * Time.deltaTime;

            if (Timer >= TimeTomove && !MOVED)
            {

                cameraAnimator.SetTrigger("CAMERA");
                MOVED = true;
            }
        }
        if (MOVED)
        {
            MapTimer += 1 * Time.deltaTime;
            if (MapTimer >= ChangeMap)
            {
                
                SceneManager.LoadScene("startGame");
            }
        }

        if (Input.GetKeyDown(KeyCode.E)&& !Pressed)
        {
            coffinanimator.SetTrigger("COFFIN");
            soundeffect.Play();
            canvas.SetActive(false);
            startTimer = true;
            Pressed = true;

        }
    }




}
