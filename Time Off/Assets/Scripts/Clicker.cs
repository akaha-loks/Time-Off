using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Clicker : MonoBehaviour
{
    private int wasClicks;
    public int needClicks;
    public Text wasClicksTxt;
    public Text needClickTxt;


    private void Update()
    {
        needClickTxt.text = "" + needClicks;
        if(wasClicks > needClicks)
        {
            needClicks += 10;
        }
        if(needClicks < wasClicks)
        {
            SceneManager.LoadScene(0);
        }
    }
    public void Clicking()
    {
        wasClicks += 1;
        wasClicksTxt.text = "" + wasClicks;
    }
}
