using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRb;
    [SerializeField] private List<GameObject> prefabs;
    [SerializeField] private int step;
    private int currentGameObject;

    void Start()
    {
        StartCoroutine(IGenerateEnviropment());
    }
    
    
    private IEnumerator IGenerateEnviropment()
    {
        while (true)
        {
            int value = ((int)transform.position.z + 50) % step;
            if (value == 0)
            {
                
                currentGameObject = Random.Range(0, prefabs.Count);
                GameObject clone = Instantiate(prefabs[currentGameObject], new Vector3(0, 15.5f + prefabs[currentGameObject].transform.lossyScale.y/2,transform.position.z + 50 + step), Quaternion.Euler(Vector3.zero));
            }
            if(playerRb.velocity.z >= 1) yield return new WaitForSeconds(2/playerRb.velocity.z);
            else
            {
                yield return new WaitForSeconds(0.2f);
            }
        }
    }
}
