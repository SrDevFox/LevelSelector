using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public UIController UI_Controller;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
            UI_Controller.MenuOpenClosed();
    }
}
