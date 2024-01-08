```csharp
// Script to make the attached object follow another GameObject (player) with a specific offset

public class FollowPlayer : MonoBehaviour
{
    public GameObject player; // Reference to the player GameObject in the scene
    private Vector3 offset = new Vector3(0, 5, -10); // Offset values for camera positioning

    // Update is called once per frame after all Update functions have been called
    void LateUpdate()
    {
        // Set the camera position to be the player's position plus the defined offset
        transform.position = player.transform.position + offset;
    }
}
```
