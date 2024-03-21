using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1ItemController : MonoBehaviour
{
    public GameObject menuObject1;
    public GameObject menuObject2;
    public GameObject menuObject3;

    private void Awake()
    {
        // hide menu objects when loading
        menuObject1.SetActive(false);
        menuObject2.SetActive(false);
        menuObject3.SetActive(false);
    }

    void Start()
    {
        ShowMenuObject(P1MenuController.selectedItem);
    }

    public void ShowMenuObject(string itemName)
    {
        if (itemName == menuObject1.name)
        {
            menuObject1.SetActive(true);
            menuObject2.SetActive(false);
            menuObject3.SetActive(false);
        }
        else if (itemName == menuObject2.name)
        {
            menuObject2.SetActive(true);
            menuObject1.SetActive(false);
            menuObject3.SetActive(false);
        }
        else if (itemName == menuObject3.name)
        {
            menuObject3.SetActive(true);
            menuObject1.SetActive(false);
            menuObject2.SetActive(false);
        }
    }
}
