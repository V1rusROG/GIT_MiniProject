using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text Txt_Timer;
    public float currentTime = 0f;
    public float startingTime = 60f;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Txt_Timer.text = "Time: " + currentTime.ToString();

        if(currentTime <= 0)
        {
            SceneManager.LoadScene(sceneName: "Losing Page");
        }
    }
}
