using UnityEngine;

public class Destroyer : MonoBehaviour
{
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exit");
        Destroy(other.gameObject);
    }
}
