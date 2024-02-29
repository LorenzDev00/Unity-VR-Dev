public class PlayerController : MonoBehaviour
{
    // Public variable for player speed
    public float speed;

    // Private variables for Rigidbody, focal point, and power-up state
    private Rigidbody playerRb;
    private GameObject focalPoint;
    private bool hasPowerup = false;

    // Public variable for power-up indicator and game over state
    public GameObject powerUpIndicator;
    public bool gameIsOver = false;

    // Start is called before the first frame update
    void Start()
    {
        // Get the player's Rigidbody component and find the focal point in the scene
        playerRb = GetComponent<Rigidbody>();
        focalPoint = GameObject.Find("FocalPoint");
    }

    // Update is called once per frame
    void Update()
    {
        // Get the player's forward input and move the player using AddForce
        float forwardInput = Input.GetAxis("Vertical");
        playerRb.AddForce(focalPoint.transform.forward * forwardInput * speed);

        // Update the position of the power-up indicator below the player
        powerUpIndicator.transform.position = transform.position + new Vector3(0, -0.5f, 0);

        // Check if the player has fallen below a certain Y position
        if (transform.position.y < -10)
        {
            // Set game over state and log a message
            gameIsOver = true;
            Debug.Log("Player has fallen. GameOver: " + gameIsOver);
        }
 
