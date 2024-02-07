using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonFunctions : MonoBehaviour
{
    public TMP_Text areYouSure;
    public GameObject pauseMenu;
    public int timesSaidYes;
    public GameObject areYouSureScreen;
    public GameObject controlMenu;
    public GameObject creditMenu;
    public void Startbutton()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void QuitGameButton()
    {
        SceneManager.LoadScene("Damian");
    }
    public void Quitbutton()
    {
        areYouSureScreen.SetActive(true);
        pauseMenu.SetActive(false);
    }
    public void BackButton()
    {
       pauseMenu.SetActive(false);
    }
    public void YesSure()
    {
        timesSaidYes += 1;

        switch (timesSaidYes)
        {
            case 1:
                areYouSure.text = "Are you really sure";
                break;
            case 2:
                areYouSure.text = "NOOOOOO DONT GOOO";
                break;
            case 3:
                areYouSure.text = "the pidgeon doesnt like you";
                break;
            case 4:
                Application.Quit();
                break;
        }
    }
    public void NoButton()
    {
        pauseMenu.SetActive (true);
        areYouSureScreen.SetActive (false);
    }
    public void ControlButton()
    {
        controlMenu.SetActive (true);
        pauseMenu.SetActive(false);
    }
    public void ControlBackButton()
    {
        controlMenu.SetActive(false);
        pauseMenu.SetActive(true) ;
    }
    public void CreditMenu()
    {
        creditMenu.SetActive (true);
        pauseMenu.SetActive(false);
    } public void CreditMenuBack()
    {
        creditMenu.SetActive (false);
        pauseMenu.SetActive(true);
    }

}
