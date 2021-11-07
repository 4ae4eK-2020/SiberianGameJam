using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionButter : MonoBehaviour
{
    [SerializeField] private Lose lose;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obstacle"))
        {
            lose.Lost();
        }
    }
}
