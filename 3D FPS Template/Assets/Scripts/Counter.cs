using UnityEngine;
using System.Collections.Generic;
using Core;

public class Counter : MonoBehaviour
{
    public int talkedWith = 0;

    void Update()
    {
        Interface.Instance.ShowScore(talkedWith);   
    }









}