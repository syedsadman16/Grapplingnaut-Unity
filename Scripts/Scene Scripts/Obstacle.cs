using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
	PlayerMovement playerMovement; 
    // Start is called before the first frame update
    void Start()
    {
		playerMovement = GameObject.FindObjectOfType<PlayerMovement>(); 
    }

	private void onCollisionEnter (Collision collision) // Kill player 
	{
		Debug.Log("Checking!");
		if(collision.gameObject.name == "Player") // NOT WORKING 
		{
			Debug.Log("Player died"); // QUOC DEBUG 
	//		playerMovement.Die(); 
		}
	}
    // Update is called once per frame
    void Update()
    {
        
    }
}
