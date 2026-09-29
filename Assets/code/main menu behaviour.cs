using UnityEngine;
using System;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class mainmenubehaviour : MonoBehaviour
{
   
    public void Startgame()
    {
        Debug.Log("start button pressed");
        SceneManager.LoadScene(1);
    }


    public void OpenOptions() 
    {
        Debug.Log("options button pressed");
        SceneManager.LoadScene(2);
    }
    public void OpenQB()
    {
        Debug.Log("quit button pressed");
        SceneManager.LoadScene(3);
    }
}
