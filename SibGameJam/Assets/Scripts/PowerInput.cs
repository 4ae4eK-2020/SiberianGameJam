using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PowerInput : MonoBehaviour
{
    [SerializeField] private float power;
    [SerializeField] public float publicPower;
    
    [SerializeField] private PlayerController playerController;

    [SerializeField] private Slider powerBar;

    private float Timer;

    /*public void Start()
    {
        publicPower = 1;
        //playerController.Acceleration();
        publicPower = 0;
    }

    public void Update()
    {
        Timer += Time.deltaTime;

        if (Timer > 0.4)
        {
            if (Input.GetKey("space"))
            {
                power += Time.deltaTime * 2;
            }
            else if (Input.GetKeyUp("space"))
            {
                if (power > 1) power = 1;
                publicPower = power;
                //playerController.Acceleration();
                power = 0;
                Timer = 0;
            }
        }
        powerBar.value = power;
    }
    */
}
