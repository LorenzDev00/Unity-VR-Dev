public class DestroyOutOfBounds : MonoBehaviour
{
    // Public variables to set upper and lower bounds for the object's position
    public float topBound = 30;
    public float lowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        // Initialization code can go here if needed
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the object's position along the z-axis is above the topBound
        if (transform.position.z > topBound)
        {
            // Destroy the GameObject if it goes beyond the upper bound
            Destroy(gameObject);
        }
        // Check if the object's position along the z-axis is below the lowerBound
        else if (transform.position.z < lowerBound)
        { 
            // Destroy the GameObject if it goes below the lower bound
            Destroy(gameObject);  
        }    
    }

}
