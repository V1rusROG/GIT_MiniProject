using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManagerScript : MonoBehaviour
{
    public Text WrongAnswer;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(AnswerIncorrect());
        if (Input.GetKey(KeyCode.Space))
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
    }

    public void NewGame()
    {
        SceneManager.LoadScene(sceneBuildIndex: 2);
        // This is to select the desired Theme 
    }

    public void HowToPlay()
    {
        SceneManager.LoadScene(sceneBuildIndex: 1);
    }

    public void Quit()
    {
        Application.Quit();
    }

    public void BackToMenu()
    {
        SceneManager.LoadScene(sceneBuildIndex: 0);
    }

    public void Horror1()
    {
        SceneManager.LoadScene(sceneBuildIndex: 3);
        // if the horror theme is selected the first question will load
    }

    public void Horror2()
    {
        SceneManager.LoadScene(sceneBuildIndex: 4);
        // Second Question for Horror Theme
    }

    public void Horror3()
    {
        SceneManager.LoadScene(sceneBuildIndex: 5);
        // Third Question for Horror Theme
    }

    public void Horror4()
    {
        SceneManager.LoadScene(sceneBuildIndex: 6);
        // Fourth Question for Horror Theme
    }

    public void Horror5()
    {
        SceneManager.LoadScene(sceneBuildIndex: 7);
        // Fifth Question for Horror Theme
    }

    public void Horror6()
    {
        SceneManager.LoadScene(sceneBuildIndex: 8);
        // Sixth Question for Horror Theme
    }

    public void Horror7()
    {
        SceneManager.LoadScene(sceneBuildIndex: 9);
        // Seventh Question for Horror Theme
    }

    public void Horror8()
    {
        SceneManager.LoadScene(sceneBuildIndex: 10);
        // Eighth Question for Horror Theme
    }

    public void Horror9()
    {
        SceneManager.LoadScene(sceneBuildIndex: 11);
        // Nineth Question for Horror Theme
    }

    public void Horror10()
    {
        SceneManager.LoadScene(sceneBuildIndex: 12);
        // Tenth Question for Horror Theme
    }

    public void VictoryPage()
    {
        SceneManager.LoadScene(sceneName: "Winning Page");
        // Win Page
    }

    IEnumerator AnswerIncorrect()
    {
        WrongAnswer.enabled = true;
        WrongAnswer.gameObject.SetActive(true);
        yield return new WaitForSeconds(1);
        WrongAnswer.enabled = false;
        WrongAnswer.gameObject.SetActive(false);
    }

    public void ReturnToMenu()
    {
        
    }

    public void Escape()
    {
      
    }
}
