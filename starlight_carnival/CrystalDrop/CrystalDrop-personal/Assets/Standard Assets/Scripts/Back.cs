using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class Back : MonoBehaviour
{
    public Button back;

    void Start ()
    {
        back = back.GetComponent<Button>();
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(0);
    }
}
