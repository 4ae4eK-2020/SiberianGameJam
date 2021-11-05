using UnityEngine;

public class Lose : MonoBehaviour
{
   public GameObject textMeshPro;

   void Start()
   {
      textMeshPro = GameObject.Find("Lose").transform.GetChild(0).gameObject;
   }
   
   private void OnCollisionEnter(Collision other)
   {
      if(other.gameObject.CompareTag("Player"))
      {
         textMeshPro.SetActive(true);
         other.gameObject.GetComponent<PlayerController>().enabled = false;
      }
   }
}
