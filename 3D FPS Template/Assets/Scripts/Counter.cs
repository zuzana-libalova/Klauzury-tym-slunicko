using UnityEngine;
using System.Collections.Generic;

public class Counter : MonoBehaviour
{
    public int talkedWith = 0;

    private HashSet<GameObject> countedObjects = new HashSet<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("TEXT"))
            return;
        if (!countedObjects.Contains(other.gameObject))
        {
            countedObjects.Add(other.gameObject);

            talkedWith++;
            Debug.Log ("Interakce číslo" + talkedWith);

            
        }
    }
}