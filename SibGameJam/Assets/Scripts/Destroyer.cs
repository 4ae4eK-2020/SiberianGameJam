using UnityEngine;

public class Destroyer : MonoBehaviour
{
    [SerializeField] private GameObject textMeshPro;
    
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exit");
        if (other.gameObject.CompareTag("Player"))
        {
            textMeshPro.SetActive(true);
            other.gameObject.GetComponent<PlayerController>().enabled = false;
        }
        else
        {
            Destroy(other.gameObject);
        }
    }
}
