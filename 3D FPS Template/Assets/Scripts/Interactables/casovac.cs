using Core;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem.Controls;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Casovac : MonoBehaviour
{

    public bool TimeRunning = true;
    public Counter counter;

    public float TimeInSeconds = 210;
     public Interface timetext;

  
  
    void Update()
    {

        if (TimeRunning)
        {
            TimeInSeconds = TimeInSeconds - Time.deltaTime;
            
        }
        

        {
        if (TimeInSeconds <= 0)
        {
            if (counter.talkedWith == 0)
            {
                SceneManager.LoadScene("EndLevelBad");
            }
            else if (counter.talkedWith > 0 && counter.talkedWith < 8)
            {
                SceneManager.LoadScene("EndLevelOk");
            }
            else if (counter.talkedWith >= 8)
            {
                SceneManager.LoadScene("EndLevelGood");
            }
        }

        }



       
           

    


    }
}
