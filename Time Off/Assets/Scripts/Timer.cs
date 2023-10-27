using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Timer : MonoBehaviour
{
    Image timeBar;
    public float maxTime = 20f;
    float timeLeft;

    private void Start()
    {
        timeBar = GetComponent<Image>();
        timeLeft = maxTime;
    }

    private void Update()
    {
        if (timeLeft > 0)
        {
            timeLeft -= Time.deltaTime;
            timeBar.fillAmount = timeLeft / maxTime;
        }
        else
        {
            SceneManager.LoadScene(0);
        }
    }
}
