using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;

    public float startTime;

    public static float points;

    // Start is called before the first frame update
    void Start()
    {
        startTime = 120f;
    }

    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;
        timeText.text = "Time Left:" + startTime.ToString("0");

        scoreText.text = "Score: " + points.ToString();
    }
}
