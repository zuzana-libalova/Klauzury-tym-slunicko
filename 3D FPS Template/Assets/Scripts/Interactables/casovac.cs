using Core;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Casovac : MonoBehaviour
{

    public bool TimeRunning = true;
    public float TimeInSeconds = 210;
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
