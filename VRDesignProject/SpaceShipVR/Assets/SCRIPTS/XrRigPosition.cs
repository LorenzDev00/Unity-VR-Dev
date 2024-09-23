using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class XrRigPosition : MonoBehaviour
{
    // A reference to the Transform component of the XR rig.
    private Transform xrRigTransform;

    // The fixed Y position to which the XR rig should be set.
    float positionY = 2f;

    // Start is called before the first frame update.
    void Start()
    {
        // Get and store the Transform component of the GameObject this script is attached to.
        xrRigTransform = GetComponent<Transform>();
    }

    // Update is called once per frame.
    void Update()
    {
        // Create a new Vector3 with the original X and Z positions, but with the Y position set to positionY.
        Vector3 newXrRigPosition = new Vector3(xrRigTransform.position.x, positionY, xrRigTransform.position.z);

        // Assign the new Vector3 to the position of the Transform, effectively setting the Y position.
        xrRigTransform.position = newXrRigPosition;
    }
}
