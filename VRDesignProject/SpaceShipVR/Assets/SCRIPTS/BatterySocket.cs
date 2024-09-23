using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class BatterySocket : MonoBehaviour
{
    // Boolean field to indicate whether a battery is currently placed in the socket.
    public bool isBatteryPlaced = false;

    // This method is called automatically by Unity when another collider enters the trigger collider attached to this GameObject.
    private void OnTriggerEnter(Collider other)
    {
        // Check if the object entering the trigger has the tag "Battery".
        if (other.CompareTag("Battery"))
        {
            // Set the flag to true, indicating a battery is present in the socket.
            isBatteryPlaced = true;
        }
    }

    // This method is called automatically by Unity when another collider exits the trigger collider attached to this GameObject.
    private void OnTriggerExit(Collider other)
    {
        // Check if the object exiting the trigger has the tag "Battery".
        if (other.CompareTag("Battery"))
        {
            // Set the flag to false, indicating the battery has been removed from the socket.
            isBatteryPlaced = false;
        }
    }
}

