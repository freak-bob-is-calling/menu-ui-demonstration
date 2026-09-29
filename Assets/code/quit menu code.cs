using UnityEngine;
using UnityEngine.SceneManagement;

public class quitmenucide : MonoBehaviour
{
    
    static void QuitYes()
    {
        Debug.Log("Quitting the Player");
    }

    [RuntimeInitializeOnLoadMethod]
    static void RunOnStart()
    {
        Application.quitting += QuitYes;
    }

   
    public void QuitGameYes()
    {
        Debug.Log("Quit button pressed");

        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }

    public void QuitGameNo()
    {
        Debug.Log("no was pressed for quit");
        SceneManager.LoadScene(0);
    }
}