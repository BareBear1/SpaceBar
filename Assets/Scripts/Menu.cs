using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour
{
    public Text highScore5Text;
    public int highScore5;
    public Text highScore10Text;
    public int highScore10;
    public Text highScore20Text;
    public int highScore20;
    public Text highScore60Text;
    public int highScore60;

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("HighScore"))
        {
            highScore5 = PlayerPrefs.GetInt("HighScore");
            highScore5Text.text = highScore5.ToString();
        }

        if (PlayerPrefs.HasKey("HighScore1"))
        {
            highScore10 = PlayerPrefs.GetInt("HighScore1");
            highScore10Text.text = highScore10.ToString();
        }

        if (PlayerPrefs.HasKey("HighScore2"))
        {
            highScore20 = PlayerPrefs.GetInt("HighScore2");
            highScore20Text.text = highScore20.ToString();
        }

        if (PlayerPrefs.HasKey("HighScore3"))
        {
            highScore60 = PlayerPrefs.GetInt("HighScore3");
            highScore60Text.text = highScore60.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Reset();
        }
    }

    public void Sec5()
    {
        SceneManager.LoadScene("Space5");
    }

    public void Sec10()
    {
        SceneManager.LoadScene("Space10");
    }

    public void Sec20()
    {
        SceneManager.LoadScene("Space20");
    }

    public void Sec60()
    {
        SceneManager.LoadScene("Space60");
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
        highScore5Text.text = "0";

        PlayerPrefs.DeleteKey("HighScore1");
        highScore10Text.text = "0";

        PlayerPrefs.DeleteKey("HighScore2");
        highScore20Text.text = "0";

        PlayerPrefs.DeleteKey("HighScore3");
        highScore60Text.text = "0";
    }
}
