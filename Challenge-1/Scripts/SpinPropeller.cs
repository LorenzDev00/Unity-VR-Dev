public class SpinPropeller : MonoBehaviour
{
    // Public variable to control the spin velocity.
    public float spinVelocity;

    // Default spin input value.
    public float spinInput = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate the object around its forward axis based on spinVelocity.
        transform.Rotate(Vector3.forward * Time.deltaTime * spinVelocity);
    }
}
