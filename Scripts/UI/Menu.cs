using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menu;
    [SerializeField] private AudioClip _buttonPress;

    public static bool ButtonClick { get; private set; }

    private void Start()
    {
        ButtonClick = false;
    }

    public void OnContinueClick()
    {
        ButtonClick = false;
        PlayMusic();
        _menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void OnExitClick()
    {
        PlayMusic();
        Application.Quit();
    }

    public void OnReturnMenuClick()
    {
        Time.timeScale = 1;
        ButtonClick = false;
        PlayMusic();
        SceneManager.LoadScene(0);
    }

    public void OnEscMenuClick()
    {
        ButtonClick = true;
        PlayMusic();
        _menu.SetActive(true);
        Time.timeScale = 0;
    }

    private void PlayMusic()
    {
        GetComponent<AudioSource>().PlayOneShot(_buttonPress);
    }
}