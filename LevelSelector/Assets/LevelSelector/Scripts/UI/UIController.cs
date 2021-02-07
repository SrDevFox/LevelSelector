using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public GameObject Menu;

    public void MenuOpenClosed()
    {
        if (Menu == null)
            Menu = GameObject.Find("Menu");
        else
        {
            if (Menu.activeSelf)
                DesactiveObject(Menu);
            else
                ActiveObject(Menu);
        }
    }

    public void ActiveObject(GameObject _object) => _object.SetActive(true);
    public void DesactiveObject(GameObject _object) => _object.SetActive(false);    
}
