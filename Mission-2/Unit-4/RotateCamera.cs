public class RotateCamera : MonoBehaviour
{
    // Rotation speed of the camera
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal input from the user (e.g., arrow keys or joystick)
        float horizontalInput = Input.GetAxis("Horizontal");

        // Rotate the camera around the Y-axis based on the user's horizontal input
        // multiplied by rotation speed and deltaTime for smooth movement
        transform.Rotate(Vector3.up, horizontalInput * rotationSpeed * Time.deltaTime);
    }
}