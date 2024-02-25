// This script destroys the game object it is attached to when it moves past a specified left boundary.

public class DestroyOutOfBounds : MonoBehaviour
{
    // The left boundary beyond which the object should be destroyed.
    public float leftBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        // No initialization required in Start().
    }

    // Update is called once per frame
    void Update()
    {
        // If the object's x position is less than the left boundary...
        if (transform.position.x < leftBound)
        {
            // Destroy the game object.
            Destroy(gameObject);
        }
    }
}
