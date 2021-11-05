using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform playerTransform;
    [SerializeField] private Vector3 offset;

    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
    }
    
    void Update()
    {
        transform.position = playerTransform.position + offset;
    }
}
