using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Awake()
    {
        // Unhide the mouse cursor
        Cursor.visible = true;

        // Unlock the cursor (if it was previously locked)
        Cursor.lockState = CursorLockMode.None;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameStart()
    {
        SceneManager.LoadScene("Main");
    }
}
