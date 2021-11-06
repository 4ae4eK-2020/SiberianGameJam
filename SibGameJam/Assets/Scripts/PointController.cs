using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    [SerializeField] private int Points;
    [SerializeField] private Text score;
    
    
    private float time;
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            Points += 10;
            time = 0;
            score.text = Points.ToString();
        }
    }
}
