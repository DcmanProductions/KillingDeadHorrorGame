using UnityEngine;
using System.Collections;

public class LockCursor : MonoBehaviour
{

    public static CursorLockMode wantedMode;
    public PauseMenu pauseMenu;
    public bool showCursor;
    // Apply requested cursor state
    void SetCursorState()
    {
         Cursor.lockState = wantedMode;
         // Hide cursor when locking
         Cursor.visible = (CursorLockMode.Locked != wantedMode);
        
        if (Input.GetKeyDown(KeyCode.Escape) && !pauseMenu.isOpen)
        {
            Cursor.lockState = wantedMode = CursorLockMode.None;
            //pauseMenu.isOpen = true;
            showCursor = true;
        }
       if (Input.GetKeyDown(KeyCode.Escape) && pauseMenu.isOpen)
        {
            Cursor.lockState = wantedMode = CursorLockMode.Locked;
            Cursor.lockState = wantedMode = CursorLockMode.Confined;
            //pauseMenu.isOpen = false;
            showCursor = false;
        }


    }

    void Start()
    {
        Cursor.visible = showCursor;
        wantedMode = CursorLockMode.Locked;
    }


    void Update()
    {
        SetCursorState();
    }

    /*
    void OnGUI()
    {
        GUILayout.BeginVertical();
        // Release cursor on escape keypress
        if (Input.GetKeyDown(KeyCode.Escape))
            Cursor.lockState = wantedMode = CursorLockMode.None;

        switch (Cursor.lockState)
        {
            case CursorLockMode.None:
                GUILayout.Label("Cursor is normal");
                if (GUILayout.Button("Lock cursor"))
                    wantedMode = CursorLockMode.Locked;
                if (GUILayout.Button("Confine cursor"))
                    wantedMode = CursorLockMode.Confined;
                break;
            case CursorLockMode.Confined:
                GUILayout.Label("Cursor is confined");
                if (GUILayout.Button("Lock cursor"))
                    wantedMode = CursorLockMode.Locked;
                if (GUILayout.Button("Release cursor"))
                    wantedMode = CursorLockMode.None;
                break;
            case CursorLockMode.Locked:
                GUILayout.Label("Cursor is locked");
                if (GUILayout.Button("Unlock cursor"))
                    wantedMode = CursorLockMode.None;
                if (GUILayout.Button("Confine cursor"))
                    wantedMode = CursorLockMode.Confined;
                break;
        }

        GUILayout.EndVertical();

        SetCursorState();
    }*/
}
