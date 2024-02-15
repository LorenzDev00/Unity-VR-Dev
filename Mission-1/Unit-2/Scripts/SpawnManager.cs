public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs; // Array of animal prefabs to spawn
    private float spawnRangeX = 10; // Range of spawn position on X axis
    private float spawnPosZ = 20; // Fixed spawn position on Z axis
    private float startDelay = 2; // Delay before starting spawning
    private float spawnInterval = 1.5f; // Interval between spawns

    // Start is called before the first frame update
    void Start()
    {
        // Start spawning animals repeatedly after a delay
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        // No update logic for this script
    }

    // Method to spawn a random animal
    void SpawnRandomAnimal()
    {
        // Select a random animal prefab from the array
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        // Generate a random spawn position within the defined range
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
        
        // Instantiate the selected animal prefab at the generated spawn position
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
