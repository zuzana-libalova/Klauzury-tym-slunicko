using Core;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class casovac : MonoBehaviour
{

    bool TimeRunning = true;
    float TimeInSeconds = 10;
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
