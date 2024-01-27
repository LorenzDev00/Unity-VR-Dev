// Speed of the plane's movement
public float speed = 5.0f;

// Speed of rotation
public float rotationSpeed;
// User input for rotation
public float rotationInput;

// User input for forward movement
public float forwardInput;

// Start is called before the first frame update
void Start()
{
    // Initialization code can go here if needed
}

// Update is called once per frame
void FixedUpdate()
{
    // Get the user's horizontal input for forward movement
    forwardInput = Input.GetAxis("Horizontal");

    // Get the user's vertical input for rotation
    rotationInput = Input.GetAxis("Vertical"); 

    // Move the plane forward at a constant rate based on input
    transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

    // Rotate the plane up/down based on input
    transform.Rotate(Vector3.right * rotationSpeed * Time.deltaTime * rotationInput);
}
