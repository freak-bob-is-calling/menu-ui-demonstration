using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenubuttones : MonoBehaviour
{
    
    public void BackButton()
    {
        SceneManager.LoadScene(1);
    }

    public void Quitbutton()
    {
        Debug.Log("quit button pressed");
        SceneManager.LoadScene(0);
    }
}
