using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class PauseManager : MonoBehaviour
{
    public Canvas quitMenu;
    public Canvas pauseMenu;
    public Button yes, no, resume, quit, pause;
    bool isPaused = false;

    void Start()
    {
        quitMenu = quitMenu.GetComponent<Canvas>();
        pauseMenu = pauseMenu.GetComponent<Canvas>();
        yes = yes.GetComponent<Button>();
        no = no.GetComponent<Button>();
        resume = resume.GetComponent<Button>();
        quit = quit.GetComponent<Button>();
        pause = pause.GetComponent<Button>();

        quitMenu.enabled = false;
    }

    void Update()
    {
        if (isPaused == true)
        {
            pauseMenu.enabled = true;
            Time.timeScale = 0f;
        }
        else
        {
            pauseMenu.enabled = false;
            Time.timeScale = 1f;
        }
    }

    public void Pause()
    {
        isPaused = true;
    }

    public void Resume()
    {
        isPaused = false;
    }

    public void Quit()
    {
        quitMenu.enabled = true;
    }

    public void NoPressed()
    {
        quitMenu.enabled = false;
    }

    public void YesPressed()
    {
        SceneManager.LoadScene(0);
    }
}
