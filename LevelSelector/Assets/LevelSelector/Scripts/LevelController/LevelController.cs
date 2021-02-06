using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public void EnterInLevel(int valueLevel) => SceneManager.LoadScene(valueLevel);
}
