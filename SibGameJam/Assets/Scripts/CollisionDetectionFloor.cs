using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetectionFloor : MonoBehaviour
{
    [SerializeField] private Lose lose;
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            lose.Lost();
        }
    }
}
