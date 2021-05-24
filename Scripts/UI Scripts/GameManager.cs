using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class GameManager : MonoBehaviour
{

    int score;
    public static GameManager inst;
    [SerializeField] Text PointText;
    public float pointAmount; 
    private void Start()
    {
        if (PlayerPrefs.HasKey("point"))
        {
            Debug.Log("GAMEMANAGER IF STATEMENT");
            pointAmount = PlayerPrefs.GetFloat("point", 0);
            PointText.text = "Score: " + pointAmount; 
        }
        else
        {
            Debug.Log("GAMEMANAGER ELSE STATEMENT");
            PointText.text = "Score: 0";
        }
    }
    public void IncrementScore()
    {
        pointAmount++;
        Debug.Log("Point increment");
        PointText.text = "Score: " + pointAmount;
        PlayerPrefs.SetFloat("point", pointAmount); 
    }
    private void Awake()
    {
        inst = this; 
    }
}
