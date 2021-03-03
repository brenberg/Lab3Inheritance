using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class TextScript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI timeText;

    public float startTime;
    public static float points;

    public GameObject cardBoard;
    //public float trasperancyV;
    public GameObject infoText;

    // Start is called before the first frame update
    void Start()
    {
        startTime = 120f;
    }

    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;
        timeText.text = "Time Left: " + startTime.ToString("0");

        scoreText.text = "Score: " + points.ToString();

        if (Input.GetMouseButtonDown(0))
        {
            //cardBoard.color.
            cardBoard.SetActive(false);
            infoText.SetActive(false);
        }

        if(startTime <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }
}
