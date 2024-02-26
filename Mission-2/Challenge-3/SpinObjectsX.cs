public class SpinObjectsX : MonoBehaviour
{
    public float spinSpeed = 5.0f;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
    }
}
