using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class CountDownTimer : MonoBehaviour
{
    [SerializeField] float startTime = 5f;
    [SerializeField] Slider slider;
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] Text finalscore;

    public GameObject sliderobject;
    public GameObject GameOverPanel;
    public GameObject Score;


    float timer = 0f;
    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 1;
        StartCoroutine(Timer());
        if (timer > 0)
        {
            GameOverPanel.SetActive(false);
        }

        if (timer > 0)
        {
            sliderobject.SetActive(true);
        }


    }


    private IEnumerator Timer()
    {
         timer = startTime;
        do
        {
            timer -= Time.deltaTime;
            slider.value = timer / startTime;

            FormatText();

            yield return null;

        }
        while (timer > 0);


       

    }

    private void FormatText()
    {
        int seconds = (int)(timer % 60);
        timerText.text = "";
        if (seconds > 0) { timerText.text += seconds + "s"; }
    }
    void Update()
    {
        if (timer <= 0)
        {
         
            GameOverPanel.SetActive(true);


        }
        if (timer <= 0)
        {
            sliderobject.SetActive(false);
        }

        if (timer <= 0)
            {
                Time.timeScale = 0;
               

            }
    }

    }