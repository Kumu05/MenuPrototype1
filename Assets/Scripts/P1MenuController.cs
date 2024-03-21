using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class P1MenuController : MonoBehaviour
{
    public string nextSceneName;
    public static string selectedItem = "";

    public void LoadItemScene(string itemName)
    {
        selectedItem = itemName;
        if (SceneManager.GetActiveScene() != SceneManager.GetSceneByName(nextSceneName))
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}
