public class PlayerControllerX : MonoBehaviour
{
    public bool gameOver;

    public float floatForce;
    private float gravityModifier = 1.5f;
    private Rigidbody playerRb;

    public ParticleSystem explosionParticle;
    public ParticleSystem fireworksParticle;

    private AudioSource playerAudio;
    private AudioSource gameAudio;
    public AudioClip moneySound;
    public AudioClip explodeSound;
    public AudioClip boundTouchSound;

    public float upperBound = 14.0f;
    public float lowerBound = 2.0f;
    private bool isInBounds = true; 


    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity *= gravityModifier;
        playerAudio = GetComponent<AudioSource>();
        gameAudio = Camera.main.GetComponent<AudioSource>();
        

        // Apply a small upward force at the start of the game
        playerRb = GetComponent<Rigidbody>();
        playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);

    }

    // Update is called once per frame
    void Update()
    {
        if (playerRb.transform.position.y > upperBound)
        {
            isInBounds = false;
            playerAudio.PlayOneShot(boundTouchSound, 1.0f);
            playerRb.AddForce(Vector3.down * 0.5f,ForceMode.Impulse);
        }
        else
        {
            isInBounds = true;
            // While space is pressed and player is low enough, float up
            if (Input.GetKey(KeyCode.Space) && !gameOver && isInBounds)
            {
                playerRb.AddForce(Vector3.up * floatForce);
            }
        }
        
        
    }

    private void OnCollisionEnter(Collision other)
    {
        // if player collides with bomb, explode and set gameOver to true
        if (other.gameObject.CompareTag("Bomb"))
        {
            explosionParticle.Play();
            playerAudio.PlayOneShot(explodeSound, 1.0f);
            gameOver = true;
            gameAudio.Stop();
            Debug.Log("Game Over!");
            Destroy(other.gameObject);
        } 

        // if player collides with money, fireworks
        else if (other.gameObject.CompareTag("Money"))
        {
            fireworksParticle.Play();
            playerAudio.PlayOneShot(moneySound, 1.0f);
            Destroy(other.gameObject);

        }

        else if (other.gameObject.CompareTag("Ground") && !gameOver)
        {
            playerAudio.PlayOneShot(boundTouchSound, 1.0f);
            playerRb.AddForce(Vector3.up * 6, ForceMode.Impulse);
        }

    }

}