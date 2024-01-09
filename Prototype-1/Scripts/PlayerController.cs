// Script controlling object movement based on speed
public class NewBehaviourScript : MonoBehaviour
{
    // Variables for controlling movement
    public float speed = 5.0f; // Speed of the vehicle
    public float turnSpeed = 25.0f; // Turning speed of the vehicle
    public float horizontalInput; // Input for horizontal movement
    public float forwardInput; // Input for forward movement

    // Update is called once per frame
    void Update()
    {
        // Get input for horizontal and forward movement
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        
        // Move the vehicle forward based on input
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        
        // Rotate the vehicle based on horizontal input for turning
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);
    }
}
