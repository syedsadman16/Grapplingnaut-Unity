using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class FinalPoint : MonoBehaviour
{
    public float pointNumber;
    public TextMeshProUGUI finalPointText; 
    // Start is called before the first frame update
    void Start()
    {
        pointNumber = PlayerPrefs.GetFloat("point", 0);
        finalPointText.text = pointNumber.ToString("0"); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
