using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitFPS : MonoBehaviour
{
    [SerializeField] private int _targetFPS = 60;

    private void Awake()
    {
        QualitySettings.vSyncCount = 0;
        Application.targetFrameRate = _targetFPS;
    }

    private void Update()
    {
        if (Application.targetFrameRate != _targetFPS)
        {
            Application.targetFrameRate = _targetFPS;
        }
    }
}
