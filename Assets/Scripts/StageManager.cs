using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class StageManager: MonoBehaviour
{

    private int minite;
    private float second;
    private int oldSecond;
    public Text timeLabel;

    // Use this for initialization
    void Start()
    {
        minite = 0;
        second = 0f;
        oldSecond = 0;

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.timeScale > 0)
        {
            second += Time.deltaTime;

            if (second >= 60.0f)
            {
                minite++;
                second = second - 60;
            }

            if ((int)second != oldSecond)
            {
                timeLabel.text = minite.ToString("00") + ":" + second.ToString("00");

            }

            oldSecond = (int)second;
        }

    }
}