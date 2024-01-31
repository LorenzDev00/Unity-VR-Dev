public class PlayerController : MonoBehaviour
{
    public float horiziontalInput; // Horizontal input from the player.
    public float speed = 10.0f; // Movement speed of the player.
    public float xRange = 10; // Movement boundary for the player.

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can be added here if needed.
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the player is beyond the left movement boundary.
        if (transform.position.x < -xRange)
        {
            // If so, set the player's position to the left boundary.
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }
        // Check if the player is beyond the right movement boundary.
        else if (transform.position.x > xRange)
        {
            // If so, set the player's position to the right boundary.
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }
                
        // Get the horizontal input from the player (left/right arrow keys or A/D keys).
        horiziontalInput = Input.GetAxis("Horizontal");

        // Move the player horizontally based on input and speed.
        transform.Translate(Vector3.right * Time.deltaTime * speed * horiziontalInput);

        // Check if the space key is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
        // If space key is pressed, instantiate a projectilePrefab at the current object's position
        // and with the same rotation as the projectilePrefab's initial rotation
        Instantiate(projectilePrefab, transform.position, projectilePrefab.transform.rotation);
        }        
    }
}
