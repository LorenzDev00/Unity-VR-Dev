public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;   // Initial position of the object
    private float repeatWidth;  // Half the width of the object's collider

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;  // Store the initial position of the object
        repeatWidth = GetComponent<BoxCollider>().size.x / 2;  // Calculate half the width of the object's collider
    }

    // Update is called once per frame
    void Update()
    {
        // If the object has moved left beyond its initial position minus half its width...
        if(transform.position.x < startPos.x - repeatWidth)
        {
            // Move the object back to its initial position, creating a repeating background effect
            transform.position = startPos;
        }
    }
}
