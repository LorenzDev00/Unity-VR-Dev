// Script controlling object movement based on speed
public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5.0f; // Speed variable for object movement

    void Update()
    {
        // Move the object forward based on speed and time
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }
}
