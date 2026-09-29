using UnityEngine;
using System;
using UnityEngine.Rendering;
using UnityEngine.SceneManagement;

public class backbuttonscript : MonoBehaviour
{
    public void BackButton()
    {
        Debug.Log("Back button pressed");
        SceneManager.LoadScene(0);
    }
}
