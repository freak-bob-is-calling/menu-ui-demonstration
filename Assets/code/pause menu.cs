using UnityEngine;
using System;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;
public class pausemenu : MonoBehaviour
{
    public void Settingsmenu() 
    {
        Debug.Log("settings menu button pressed");
        SceneManager.LoadScene(2);
    }

    public void Quitbutton()
    {
        Debug.Log("quit button pressed");
        SceneManager.LoadScene(0);
    }
    
}
