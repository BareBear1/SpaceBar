using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMaster1 : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;
    public Text highScoreText;
    public int highScore;
    public Text timerText;
    public float theTime = 10;
    public float speed = 1f;
    public bool outOfTime;
    public bool hasPressed;
    public GameObject obj;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore1"))
        {
            highScore = PlayerPrefs.GetInt("HighScore1");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore1", highScore);
        }

        highScoreText.text = highScore.ToString();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Reset();
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }

        if (outOfTime == false)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                score++;
                scoreText.text = score.ToString();
                hasPressed = true;
                obj.SetActive(false);
            }
        }

        if (hasPressed == true)
        {
            if (outOfTime == false)
            {
                theTime -= Time.deltaTime * speed;
                //string minutes = Mathf.Floor((theTime % 3600) / 60).ToString("00");
                string seconds = (theTime % 60).ToString("00.00");
                timerText.text = seconds;
            }
        }

        if (theTime > 0.000000)
        {
            outOfTime = false;
        }
        else
        {
            outOfTime = true;
        }
    }

    public void Menu()
    {
        SceneManager.LoadScene("SpaceMenu");
    }

    /*public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore1");
        highScoreText.text = "0";

    }*/
}
