using UnityEngine;
using UnityEngine.SceneManagement;

public class BackgroundMusic : MonoBehaviour
{
    private static BackgroundMusic instance;

    public static BackgroundMusic Instance
    {
        get { return instance; }
    }

    private AudioSource audioSource;

    [Header("Music Tracks")]
    public AudioClip menuMusic;
    public AudioClip gameMusic;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(this.gameObject);

        audioSource = GetComponent<AudioSource>();
    }

    private void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "game")
        {
            // Only switch if we aren't already playing the game music
            if (audioSource.clip != gameMusic)
            {
                audioSource.clip = gameMusic;
                audioSource.Play();
            }
        }
        else
        {
            // Switch back to menu music for non-game scenes
            if (audioSource.clip != menuMusic)
            {
                audioSource.clip = menuMusic;
                audioSource.Play();
            }
        }
    }
}