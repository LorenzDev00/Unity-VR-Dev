public class Enemy : MonoBehaviour
{
    // Public variable for the speed of the enemy
    public float speed = 3.0f;

    // Private references for the Rigidbody, player GameObject, and PlayerController script
    private Rigidbody enemyRb;
    private GameObject player;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        // Get the Rigidbody component attached to this GameObject
        enemyRb = GetComponent<Rigidbody>();

        // Find the player GameObject by name
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the direction to look at the player and move towards it with specified speed
        Vector3 lookDirection = (player.transform.position - transform.position).normalized * speed;
        enemyRb.AddForce(lookDirection);

        // Check if the enemy has fallen below a certain y-position and destroy it if true
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
