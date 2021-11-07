using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using UnityEngine;
using UnityEngine.UI;

public class PointController : MonoBehaviour
{
    [SerializeField] private int Points;
    [SerializeField] private Text score;
    [SerializeField] private Transform Player;
    


    //private float time;

    private Vector3 lastPos;

    private void Awake()
    {
        lastPos = Player.position;
    }
    private void Update()
    {
        /*
        time += Time.deltaTime;
        if (time > 1)
        {
            Points += 10;
            time = 0;
            score.text = Points.ToString();
        }
        */

        if (Vector3.Distance(lastPos, Player.position) > 10f)
        {
            lastPos = Player.position;
            Points += 10;
            score.text = Points.ToString();
        }
    }
}
