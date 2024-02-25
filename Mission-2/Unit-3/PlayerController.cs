public class PlayerController : MonoBehaviour
{
    private Rigidbody playerRb;  // Reference to the player's rigidbody component.
    private Animator playerAnim; // Reference to the player's animator component.
    private AudioSource playerAudio; // Reference to the player's audio source component.

    public ParticleSystem explosionParticle; // Particle system for explosion effect.
    public ParticleSystem dirtParticle; // Particle system for dirt effect.

    public AudioClip jumpSound; // Sound clip for player jump.
    public AudioClip crashSound; // Sound clip for player crash.
    
    public float jumpForce = 10f; // Force applied to the player for jumping.
    public float gravityModifier; // Modifier for adjusting gravity.
    public bool isOnGround = true; // Flag indicating whether the player is on the ground.
    public bool gameOver; // Flag indicating whether the game is over.

    // Start is called before the first frame update
    void Start()
    {
        // Initialize references to components.
        playerRb = GetComponent<Rigidbody>();
        playerAnim = GetComponent<Animator>();
        playerAudio = GetComponent<AudioSource>();

        // Modify gravity using the specified modifier.
        Physics.gravity *= gravityModifier; 
    }

    // Update is called once per frame
    void Update()
    {
        // Check for jump input if the player is on the ground and the game is not over.
        if(Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver)
        {
            // Apply upward force to simulate jumping.
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            // Update state indicating the player is not on the ground.
            isOnGround = false;
            // Trigger jump animation.
            playerAnim.SetTrigger("Jump_trig");
            // Stop dirt particle effect.
            dirtParticle.Stop();
            // Play jump sound.
            playerAudio.PlayOneShot(jumpSound, 1.0f);
        }
    }

    // Called when a collision is detected
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the player collided with the ground.
        if (collision.gameObject.CompareTag("Ground"))
        {
            // Update state indicating the player is on the ground.
            isOnGround = true;
            // Restart dirt particle effect.
            dirtParticle.Play();
        }
        // Check if the player collided with an obstacle.
        else if (collision.gameObject.CompareTag("Obstacle"))
        {
            // Log game over.
            Debug.Log("Game Over");
            // Update state indicating the game is over.
            gameOver = true;
            // Trigger death animation.
            playerAnim.SetBool("Death_b", true);
            playerAnim.SetInteger("DeathType_int", 1);
            // Play explosion particle effect.
            explosionParticle.Play();
            // Stop dirt particle effect.
            dirtParticle.Stop();
            // Play crash sound.
            playerAudio.PlayOneShot(crashSound, 1.0f);
        }
    }
}
