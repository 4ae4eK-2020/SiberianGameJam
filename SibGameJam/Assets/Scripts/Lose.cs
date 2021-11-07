using UnityEngine;

public class Lose : MonoBehaviour
{
   [SerializeField] private GameObject losePanel;
   private bool isCollided;

   [SerializeField] private PlayerController playerController;

   
   public void Lost()
   {
      playerController.enabled = false;
      losePanel.SetActive(true);
      Time.timeScale = 0;
   }
}
