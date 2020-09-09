using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    Text text;
    public float theTime = 10;
    public float speed = 1f;
    public bool outOfTime;
    // Start is called before the first frame update

    void Start()
    {
        text = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        theTime -= Time.deltaTime * speed;
        //string minutes = Mathf.Floor((theTime % 3600) / 60).ToString("00");
        string seconds = (theTime % 60).ToString("0.0");
        text.text = seconds;

        if (theTime > 0.000000)
        {
            outOfTime = true;
        }
        else
        {
            outOfTime = false;
        }
    }
}
