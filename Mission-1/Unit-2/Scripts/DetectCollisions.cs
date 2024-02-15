public class DetectCollisions : MonoBehaviour // Class for detecting collisions
{
    // Start is called before the first frame update
    void Start() // Called at the start of the object's lifecycle
    {
        
    }

    // Update is called once per frame
    void Update() // Called every frame
    {
        
    }

    private void OnTriggerEnter(Collider other) // Called when the collider enters another collider
    {
        Destroy(gameObject); // Destroy this object
        Destroy(other.gameObject); // Destroy the other collided object
    }
}
