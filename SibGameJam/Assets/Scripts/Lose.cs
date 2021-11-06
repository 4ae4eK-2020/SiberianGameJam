using UnityEngine;

public class Lose : MonoBehaviour
{
   [SerializeField] private GameObject lose;
   private bool isCollided;

   [SerializeField] private PlayerController playerController;


   /*
   void Start()
   {
      textMeshPro = GameObject.Find("Lose").transform.GetChild(0).gameObject;
   }
   */
   
   private void OnCollisionEnter(Collision other)
   {
      if(other.gameObject.CompareTag("Player"))
      {
         //textMeshPro.SetActive(true);
         //other.gameObject.GetComponent<PlayerController>().enabled = false;
         Lost();
         
      }
   }

   private void Lost()
   {
      playerController.enabled = false;
      lose.SetActive(true);
      Time.timeScale = 0;
   }
}
