using Core;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class casovac : MonoBehaviour
{

    public bool TimeRunning = true;
    float TimeInSeconds = 180;
     public Interface timetext;

  
    void Update()
    {

        if (TimeRunning)
        {
            TimeInSeconds = TimeInSeconds - Time.deltaTime;
            timetext.ShowTime(TimeInSeconds);
        }

        if (TimeInSeconds <= 0)

        {
            SceneManager.LoadScene("EndLevel");

        }


    }
}
