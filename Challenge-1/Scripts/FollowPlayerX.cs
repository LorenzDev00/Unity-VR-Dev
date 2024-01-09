public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane; // Reference to the player object
    private Vector3 offset = new Vector3(30, 0, 20); // Offset to be applied to the following object

    // LateUpdate is called once per frame, after Update() methods
    void LateUpdate()
    {
        // Set the position of the following object to the player's position with an offset
        transform.position = plane.transform.position + offset;
    }
}
