using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0f;
    }

   public void Play()
    {
        Time.timeScale = 1f;
        panel.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
