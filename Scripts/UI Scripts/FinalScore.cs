using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using TMPro; 
public class FinalScore : MonoBehaviour
{
    public float scoreNumber;
    public TextMeshProUGUI finalScoreText;
    GUIStyle style = new GUIStyle();
    public Font MyFont;

    // Start is called before the first frame update
    void Start()
    {
        scoreNumber = PlayerPrefs.GetFloat("score", 0);
        Debug.Log("Final Score: " + scoreNumber);
        //finalScoreText.text = "Score: " + (int)scoreNumber;
        finalScoreText.text = scoreNumber.ToString("0"); 
    }
/*
    void OnGUI()
    {
        GUI.skin.font = MyFont;

        style.fontSize = 120;
        style.normal.textColor = Color.red;
        style.richText = true;
        //Fetch the PlayerPrefs settings and output them to the screen using Labels
        // new Rect(right, down, ...)
        GUI.Label(new Rect(Screen.width/2-50, Screen.height/3-25, 200, 30), " " + (int)scoreNumber, style);
    }
*/

    void OnEnable()
    {
        //scoreNumber = PlayerPrefs.GetFloat("score");
        //Console.WriteLine("This is ");
        //finalScoreText.text = "Score: " + (int)scoreNumber;
    }
}
