using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P1NavigationController : MonoBehaviour
{
    public string backSceneName;

    public void LoadMenuScene()
    {
        SceneManager.LoadScene(backSceneName);
    }
}
