using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallController : MonoBehaviour
{
   [SerializeField] private float force = 1f;
   [SerializeField] private InputManager inputManager;
   [SerializeField] private Transform ballAnchor;
   [SerializeField] private Transform launchIndicator;
   private Rigidbody ballRB;
   private bool isBallLaunched;

    void Start()
    {
        ballRB = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
        inputManager.OnSpacePressed.AddListener(LaunchBall);

        // transform.parent = ballAnchor;
        // transform.localPosition = Vector3.zero;
        // ballRB.isKinematic = true;

        ResetBall();
    }

    public void ResetBall()
    {
        isBallLaunched = false;
        ballRB.isKinematic = true;
        launchIndicator.gameObject.SetActive(true);
        transform.parent = ballAnchor;
        transform.localPosition = Vector3.zero;
    }

    private void LaunchBall() 
    {
        if (isBallLaunched) return;
        isBallLaunched = true;
        ballRB.isKinematic = false;
        // ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
        transform.parent = null;
        
        ballRB.AddForce(launchIndicator.forward * force, ForceMode.Impulse);
        launchIndicator.gameObject.SetActive(false);
        // ballRB.AddForce(transform.forward * force, ForceMode.Impulse);
    }
}
