using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReticleRotation : MonoBehaviour
{
    // Speed of rotation, in degrees per second.
    public float speed = 10f;

    // Start is called before the first frame update.
    void Start()
    {
        // Initialization code can go here if needed.
    }

    // Update is called once per frame.
    void Update()
    {
        // Rotate the object around the world's Y-axis.
        // Vector3.up represents the world Y-axis (0, 1, 0).
        // 'speed * Time.deltaTime' ensures rotation speed is consistent regardless of frame rate.
        // 'Space.World' indicates that the rotation is in world space, not local space.
        transform.Rotate(Vector3.up, speed * Time.deltaTime, Space.World);
    }
}
