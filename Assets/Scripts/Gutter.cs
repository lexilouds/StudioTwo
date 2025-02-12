using UnityEngine;

public class Gutter : MonoBehaviour
{

   private void OnTriggerEnter(Collider triggeredBody)
   {
      Rigidbody ballRigidBody = triggeredBody.GetComponent<Rigidbody>();

      if (triggeredBody.CompareTag("Ball") && !ballRigidBody.isKinematic)
      {
        float velocityMagnitude = ballRigidBody.linearVelocity.magnitude;

         ballRigidBody.linearVelocity = Vector3.zero;
         ballRigidBody.angularVelocity = Vector3.zero;

         ballRigidBody.AddForce(transform.up * velocityMagnitude, ForceMode.VelocityChange);

      }
   }
}
