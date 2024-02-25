public class MoveLeft : MonoBehaviour
{
    private float speed = 30; // Speed of leftward movement
    private PlayerController playerControllerScript; // Reference to the PlayerController script

    // Start is called before the first frame update
    void Start()
    {
        // Find and get the PlayerController script attached to the "Player" GameObject
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // If the game is not over according to the PlayerController script
        if (playerControllerScript.gameOver == false)
        {
            // Move the GameObject leftward at a constant speed
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
    }
}
