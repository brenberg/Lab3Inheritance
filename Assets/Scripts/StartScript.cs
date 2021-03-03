using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class StartScript : MonoBehaviour
{
    public static bool startup;
    public static float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //timer += Time.deltaTime;

        if (startup == true)
        {
            //PlayOutTransition();

            if (timer >= 3 && timer <= 3.5)
            {
                SceneManager.LoadScene(1);
                startup = false;
            }

            if (timer >= 10)
            {
                SceneManager.LoadScene(0);
                startup = false;
            }
        }
    }

    public void StartGame()
    {
        //startup = true;
        //timer = 0;

        SceneManager.LoadScene(1);
    }
}
