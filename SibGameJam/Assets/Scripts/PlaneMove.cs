using UnityEngine;

public class PlaneMove : MonoBehaviour
{
   [SerializeField] private Transform target;
   [SerializeField] private Vector2 offset;

   void Update()
   {
      transform.position = new Vector3(0,offset.y, target.position.z + offset.x);
   }
}
