using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class ButtonHandler : MonoBehaviour
{
    public Button play;
    public Button settings;
    public Button quit;
    public Button achievements;
    public Canvas settingsCanvas, mainMenu;
    public Button back;

    void Start()
    {
        play = play.GetComponent<Button>();
        settings = settings.GetComponent<Button>();
        quit = quit.GetComponent<Button>();
        achievements = achievements.GetComponent<Button>();
        settingsCanvas = settingsCanvas.GetComponent<Canvas>();
        mainMenu = mainMenu.GetComponent<Canvas>();
        back = back.GetComponent<Button>();
        settingsCanvas.enabled = false;
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void Settings()
    {
        settingsCanvas.enabled = true;
        mainMenu.enabled = false;
    }

    public void Achievements()
    {
        SceneManager.LoadScene(2);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
