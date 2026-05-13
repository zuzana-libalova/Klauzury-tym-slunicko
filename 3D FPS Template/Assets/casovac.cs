using Core;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class casovac : MonoBehaviour
{

   public bool TimeRunning = true;
    
    float TimeInSeconds = 10;
     public Interface timetext;

  
    void Update()
    {

        if (TimeRunning)
        {
            TimeInSeconds = TimeInSeconds - Time.deltaTime;

        }

        if (TimeInSeconds <= 0)

        {
            SceneManager.LoadScene("EndLevel");

        }


    }
}
