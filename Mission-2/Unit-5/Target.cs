public class Target : MonoBehaviour
{
    // Reference to the rigidbody component of the target
    private Rigidbody targetRb;

    // Reference to the GameManager script
    private GameManager gameManager;

    // Minimum and maximum speed for the target's movement
    private float minSpeed = 12;
    private float maxSpeed = 16;

    // Magnitude of torque applied to the target
    private float Torque = 10;

    // Range of spawn positions on the x-axis
    private float xRange = 4;

    // Spawn position on the y-axis
    private float ySpawnPos = -2;

    // Point value of the target
    public int pointValue;

    // Particle system for explosion effect
    public ParticleSystem explosionParticle;

    // Start is called before the first frame update
    void Start()
    {
        // Finding and assigning the GameManager component
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        // Assigning the rigidbody component of the target
        targetRb = GetComponent<Rigidbody>();

        // Applying random force and torque to the target
        targetRb.AddForce(RandomForce(), ForceMode.Impulse);
        targetRb.AddTorque(RandomTorque(), RandomTorque(), RandomTorque(), ForceMode.Impulse);

        // Setting random spawn position for the target
        transform.position = RandomSpawnPos();
    }

    // Update is called once per frame
    void Update()
    {
        // No code in Update for this script
    }

    // Called when the target is clicked
    private void OnMouseDown()
    {
        // Destroying the target, updating the score, and instantiating explosion effect
        Destroy(gameObject);
        gameManager.UpdateScore(pointValue);
        Instantiate(explosionParticle, transform.position, explosionParticle.transform.rotation);
    }

    // Called when the target collides with another collider
    private void OnTriggerEnter(Collider other)
    {
        // Destroying the target and triggering game over
        Destroy(gameObject);
        gameManager.GameOver();
    }

    // Generates a random force to be applied to the target
    Vector3 RandomForce()
    {
        return Vector3.up * Random.Range(minSpeed, maxSpeed);
    }

    // Generates a random torque to be applied to the target
    float RandomTorque()
    {
        return Random.Range(-Torque, Torque);
    }

    // Generates a random spawn position for the target
    Vector3 RandomSpawnPos()
    {
        return new Vector3(Random.Range(-xRange, xRange), ySpawnPos);
    }
}
