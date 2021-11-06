using UnityEngine;

public class Lose : MonoBehaviour
{
   [SerializeField] private GameObject lose;
   private bool isCollided;

   [SerializeField] private PlayerController playerController;

   void Start()
   {
      lose = GameObject.Find("Lose").transform.GetChild(0).gameObject;
      playerController = GameObject.FindWithTag("Player").GetComponent<PlayerController>();
   }
   
   private void OnCollisionEnter(Collision other)
   {
      if(other.gameObject.CompareTag("Player"))
      {
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
