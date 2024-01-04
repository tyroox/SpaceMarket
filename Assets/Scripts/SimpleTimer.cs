using UnityEngine;
 using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SimpleTimer: MonoBehaviour {
 
   public float targetTime = 90f;
   public Text time;
 
   void Update()
   {
       targetTime -= Time.deltaTime;
       time.text = "Time: " + targetTime.ToString("0.00");

       if (targetTime <= 0f)
          {
             timerEnded();
          }
   }
 
    void timerEnded()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
 }