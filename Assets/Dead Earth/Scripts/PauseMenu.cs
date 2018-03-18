using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PauseMenu : MonoBehaviour
{

    [SerializeField]
    public GameObject menu, settings;
    public bool isOpen ;

    public Button resume;
    public Button mainMenu;

    //public GameObject cursor;

    public float timeScale = 1.0f;

    // Use this for initialization
    void Start()
    {
        menu.SetActive(false);
        isOpen = false;
        Time.timeScale = timeScale = 1.0f;
        Button btnResume = resume.GetComponent<Button>();
        Button btnMenu = mainMenu.GetComponent<Button>();
        btnResume.onClick.AddListener(TaskOnClickResume);
        btnMenu.onClick.AddListener(TaskOnClickMenu);
    }
    void TaskOnClickMenu()
    {

    }
    void TaskOnClickResume()
    {
        LockCursor.wantedMode = CursorLockMode.Confined;
        LockCursor.wantedMode = CursorLockMode.Locked;
        timeScale = 1.0f;
        Time.timeScale = timeScale;
        menu.SetActive(false);
        Open(false);
        //cursor.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !isOpen && Time.timeScale == 1.0)
        {
            timeScale = 0.0f;
            Time.timeScale = timeScale;
            Open(true);
            menu.SetActive(true);
            
           // cursor.SetActive(false);
        }
        else if (Input.GetKeyDown(KeyCode.Escape)&&isOpen)
        {
            LockCursor.wantedMode = CursorLockMode.Confined;
            LockCursor.wantedMode = CursorLockMode.Locked;
            timeScale = 1.0f;
            Time.timeScale = timeScale;
            menu.SetActive(false);
            settings.SetActive(false);
            Open(false);        
        }
    }
    

    void Open(bool open)
    {
        isOpen = open;
    }
}
