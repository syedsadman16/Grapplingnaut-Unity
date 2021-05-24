using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScorePerSecond : MonoBehaviour {

	public Text scoreText;
	public float scoreAmount;
	public float pointIncreasedPerSecond;

void Start(){
	if (PlayerPrefs.HasKey("score"))
	{
		scoreAmount = PlayerPrefs.GetFloat("score", 0); 
	}
	else
	{
		scoreAmount = 0f;
		pointIncreasedPerSecond = 1f;
	}
}

void Update(){
	scoreText.text = "Time: " + (int)scoreAmount + "s";
	scoreAmount += pointIncreasedPerSecond * Time.deltaTime;
    PlayerPrefs.SetFloat ("score", scoreAmount);
}

void OnDisable()
{
		PlayerPrefs.SetFloat ("score", scoreAmount);
}

}