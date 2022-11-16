using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{
    public void StartButton()
    {

        SceneManager.LoadScene("Environment_Free");
        Time.timeScale = 1;

    }

    public void MainMenu()
    {

        SceneManager.LoadScene("Environment_Free 1");

    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}