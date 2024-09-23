using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class FireBullet : MonoBehaviour
{
    // The prefab of the bullet to be instantiated and fired.
    public GameObject bullet;

    // The point from which the bullet will be spawned.
    public Transform spawnPoint;

    // The speed at which the bullet will be fired.
    public float fireSpeed = 20;

    // Start is called before the first frame update.
    void Start()
    {
        // Get the XRGrabInteractable component attached to this GameObject.
        XRGrabInteractable grabbable = GetComponent<XRGrabInteractable>();

        // Add a listener to the 'activated' event of the XRGrabInteractable, triggering FireBulletFunction when the event occurs.
        grabbable.activated.AddListener(FireBulletFunction);
    }

    // Update is called once per frame.
    void Update()
    {
        // No updates needed for this script in the Update method.
    }

    // This function is called when the XRGrabInteractable object is activated (e.g., via trigger press).
    public void FireBulletFunction(ActivateEventArgs arg)
    {
        // Instantiate a new bullet from the bullet prefab.
        GameObject spawnedBullet = Instantiate(bullet);

        // Set the position of the spawned bullet to the spawn point's position.
        spawnedBullet.transform.position = spawnPoint.position;

        // Set the rotation of the spawned bullet to match the spawn point's rotation.
        spawnedBullet.transform.rotation = spawnPoint.rotation;

        // Assign a velocity to the bullet's Rigidbody to make it move forward.
        spawnedBullet.GetComponent<Rigidbody>().velocity = spawnPoint.forward * fireSpeed;

        // Destroy the bullet after 5 seconds to prevent clutter in the scene.
        Destroy(spawnedBullet, 5);
    }
}
