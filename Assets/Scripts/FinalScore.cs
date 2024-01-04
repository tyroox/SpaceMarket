using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    public Text score1;
    
    void Start()
    {
        score1.text = "Final Score: " + Score.finalScore.ToString();
    }
}