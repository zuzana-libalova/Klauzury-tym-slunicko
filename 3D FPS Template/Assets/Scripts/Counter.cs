using UnityEngine;
using System.Collections.Generic;

public class Counter : MonoBehaviour
{
    public int talkedWith = 0;

    
    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log ("Testing");
        if (other.CompareTag("TEXT"))
        {
            talkedWith++;
            Debug.Log ("Interakce číslo" + talkedWith);

            
        }
    }
}