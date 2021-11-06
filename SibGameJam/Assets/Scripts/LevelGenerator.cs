using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRb;
    [SerializeField] private List<GameObject> prefabs;
    [SerializeField] private int step;
    [SerializeField] private Vector3 offset;
    [SerializeField] private float direction;
    private int currentGameObject;

    void Start()
    {
        StartCoroutine(IGenerateEnviropment());
    }
    
    
    private IEnumerator IGenerateEnviropment()
    {
        while (true)
        {
            int result;
            Math.DivRem((int)transform.position.z, step, out result);
            if (result == 0)
            {
                Debug.Log("Generate object");
                currentGameObject = Random.Range(0, prefabs.Count);
                GameObject clone = Instantiate(prefabs[currentGameObject], new Vector3(offset.x, offset.y + prefabs[currentGameObject].transform.lossyScale.y/2,transform.position.z + offset.z + step), Quaternion.Euler(Vector3.zero));
                Debug.Log(clone.name + " was generated at: X=" + clone.transform.position.x + ", Y=" + clone.transform.position.y + ", Z=" + clone.transform.position.z);
            }

            Debug.Log(result);
            if(playerRb.velocity.z >= direction) yield return new WaitForSeconds(direction/playerRb.velocity.z);
            else
            {
                yield return new WaitForSeconds(0.1f * direction);
            }
        }
    }
}
