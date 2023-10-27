using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clicks : MonoBehaviour
{
    public int money;
    [SerializeField] private Text txt;

    private void Start()
    {
        txt = GetComponent<Text>();
        money = PlayerPrefs.GetInt("money");
    }
    private void Update()
    {
        txt.text = "" + money;
    }
    public void Clicking()
    {
        money += 1;
        PlayerPrefs.SetInt("money", 0 + money);
    }
}
