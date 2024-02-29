Certainly! Below is the code with added short and clear comments:

```csharp
public class SpawnManager : MonoBehaviour
{
    public GameObject enemyPrefab;
    private float spawnRange = 9.0f;
    public int enemyCount;
    public GameObject powerUpPrefab;
    private PlayerController playerControllerScript;

    // Start is called before the first frame update
    void Start()
    {
        // Find and store the PlayerController script reference
        playerControllerScript = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        // Find all active enemies in the scene
        Enemy[] enemies = FindObjectsOfType<Enemy>();
        enemyCount = enemies.Length;

        // Check if there are no enemies and the game is not over
        if (enemyCount == 0 && playerControllerScript.gameIsOver == false)
        {
            // Instantiate a power-up and a new wave of enemies
            Instantiate(powerUpPrefab, GenerateSpawnPosition(), powerUpPrefab.transform.rotation);
            SpawnEnemyWave(2);
        }
    }

    // Generate a random spawn position within the specified range
    private Vector3 GenerateSpawnPosition()
    {
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);

        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);

        return randomPos;
    }

    // Method to spawn a wave of enemies
    int enemiesToSpawn;
    private void SpawnEnemyWave(int enemiesToSpawn)
    {
        for (int i = 0; i < enemiesToSpawn; i++)
        {
            Instantiate(enemyPrefab, GenerateSpawnPosition(), enemyPrefab.transform.rotation);
        }
    }

    // OnTriggerEnter is called when a Collider enters the trigger zone
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entered Collider is a power-up
        if (other.CompareTag("PowerUp"))
        {
            // Activate power-up, destroy the power-up object, and start a countdown routine
            hasPowerup = true;
            powerUpIndicator.gameObject.SetActive(true);
            Destroy(other.gameObject);
            StartCoroutine(PowerupCoundownRoutine());
        }
    }

    // Coroutine to handle the power-up countdown
    IEnumerator PowerupCoundownRoutine()
    {
        yield return new WaitForSeconds(7);
        // Deactivate power-up after the countdown
        hasPowerup = false;
        powerUpIndicator.gameObject.SetActive(false);
    }

    // OnCollisionEnter is called when this collider/rigidbody has begun touching another rigidbody/collider
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an enemy and the player has a power-up
        if (collision.gameObject.CompareTag("Enemy") && hasPowerup)
        {
            // Apply force to the enemy to push it away from the player
            Rigidbody enemyRb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 awayfromPlayer = collision.gameObject.transform.position - transform.position;
            enemyRb.AddForce(awayfromPlayer * 10, ForceMode.Impulse);
            Debug.Log("Collided with " + collision.gameObject.name + " with powerup set to " + hasPowerup);
        }
    }
}
```

I've added comments to explain each section and the purpose of various methods and conditions.