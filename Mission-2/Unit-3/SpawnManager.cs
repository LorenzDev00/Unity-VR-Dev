public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab; // Prefab of the obstacle to spawn
    private Vector3 spawnPos = new Vector3(34, 0, 0); // Position to spawn obstacles
    private float startDelay = 2; // Initial delay before spawning starts
    private float repeatRate = 2; // Repeat rate for spawning obstacles

    private PlayerController playerControllerScript; // Reference to PlayerController script
    
    // Start is called before the first frame update
    void Start()
    {
        // Start spawning obstacles after a delay and repeat at a specified rate
        InvokeRepeating("spawnObstacle", startDelay, repeatRate);
        
        // Find and assign the PlayerController script from the "Player" GameObject
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // No actions needed in Update for this script
    }

    // Function to spawn obstacles
    void spawnObstacle()
    {
        // Check if the game is not over before spawning
        if(playerControllerScript.gameOver == false)
        {
            // Instantiate the obstaclePrefab at spawnPos with its default rotation
            Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
        }
    }
}
