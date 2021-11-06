using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    [SerializeField] private int points;
    [SerializeField] private Text scoreText;
    private float time;
    void Update()
    {
        time += Time.deltaTime;
        if (time > 1)
        {
            points += 10;
            time = 0;
            scoreText.text = points.ToString();
        }
    }
}
