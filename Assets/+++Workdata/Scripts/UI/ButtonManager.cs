
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuContainer;
    [SerializeField] private GameObject optionsMenuContainer;

    public void Button_OpenOptionMenu()
    {
        mainMenuContainer.SetActive(false);
        optionsMenuContainer.SetActive(true);
    }
    
    public void Button_OpenMainMenu()
    {
        mainMenuContainer.SetActive(true);
        optionsMenuContainer.SetActive(false);
    }
    
    public void Button_NewGame()
    {
        SceneManager.LoadScene(1);
    }

}

