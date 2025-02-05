using UnityEngine;

public class BallController : MonoBehaviour
{
   [SerializeField] private float force = 1f;
   [SerializeField] private InputManager inputManager;
   private Rigidbody ballRB;
   private bool isBallLaunched;
    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        inputManager.OnSpacePressed.AddListener(LaunchBall);
    }


    void Update()
    {
        
    }

    private void LaunchBall() 
    {
        if (isBallLaunched) return;
        isBallLaunched = true;
        ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
