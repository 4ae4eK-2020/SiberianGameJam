using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody playerRb;
    [SerializeField] private Vector3 center;
    [SerializeField] private float impulseMagnitude, speed;

    //[SerializeField] private PowerInput powerInput;

    private void Update()
    {
        playerRb.AddForce(Vector3.forward * speed, ForceMode.VelocityChange);
        if(Input.GetKeyDown(KeyCode.Space)) playerRb.AddForceAtPosition(Vector3.up * impulseMagnitude, playerRb.position + center, ForceMode.Acceleration);
    }

    /*public void Acceleration()
    {
        playerRb.AddForceAtPosition(Vector3.up * impulseMagnitude * powerInput.publicPower, playerRb.position + center, ForceMode.Acceleration);
    }*/
}
