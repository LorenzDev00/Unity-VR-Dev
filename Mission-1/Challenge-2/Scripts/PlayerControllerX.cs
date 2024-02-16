public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;

    public float startTime = 60f;
    private float currentTime;

    private void Start()
    {
        currentTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
        currentTime -= Time.deltaTime;


        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(currentTime < 57f)
            {
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
                currentTime = startTime;
            }
            else
            {
                Debug.Log("Wait a few seconds");
            }
            
        }

        // Display the time in minutes and seconds --> Challenge Bouns : spawn dogs at predefined time range 
        //int minutes = Mathf.FloorToInt(currentTime / 60);
        //int seconds = Mathf.FloorToInt(currentTime % 60);
        //Debug.LogFormat("{0:00}:{1:00}", minutes, seconds);
    }
}