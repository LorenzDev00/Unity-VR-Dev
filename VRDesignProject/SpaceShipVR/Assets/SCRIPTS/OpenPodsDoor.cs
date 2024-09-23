using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
using UnityEngine.InputSystem;

public class OpenPodsDoor : MonoBehaviour
{
    // References to battery sockets that need to be filled to open the door.
    public BatterySocket socketLeft;
    public BatterySocket socketRight;

    // GameObject to display a sign when the door can't open.
    public GameObject doorSign;

    // Animator controlling the door's animation.
    public Animator doorAnimator;

    // Name of the Animator boolean parameter that controls the door state.
    public string boolName = "Open";

    // Indicates whether the door is currently open.
    private bool doorOpened = true;

    // References to the old GameObjects representing red lights (active when door is closed).
    public GameObject RedLight1;
    public GameObject RedLight2;

    // References to the new GameObjects representing blue lights (active when door is open).
    public GameObject BlueLight1;
    public GameObject BlueLight2;

    void Start()
    {
    
    }

    void Update()
    {
        // If the door is not yet open and both battery sockets have batteries inserted.
        if (!doorOpened && socketLeft.isBatteryPlaced && socketRight.isBatteryPlaced)
        {
            // Open the door and hide the door sign.
            OpenDoor();
            doorSign.SetActive(false);

            // Replace red lights with blue lights.
            ReplaceObjectOpen();
        }
        // If either battery is removed, ensuring the door should close.
        else if (!socketLeft.isBatteryPlaced || !socketRight.isBatteryPlaced)
        {
            // Close the door and display the door sign.
            CloseDoor();
            doorSign.SetActive(true);

            // Replace blue lights with red lights.
            ReplaceObjectClosed();
        }
    }

    // Opens the door by setting the Animator's boolean parameter to true.
    void OpenDoor()
    {
        // Get the current state of the "Open" parameter from the Animator.
        bool isOpen = doorAnimator.GetBool(boolName);

        // Toggle the state of the door.
        doorAnimator.SetBool(boolName, !isOpen);

        // Mark the door as opened.
        doorOpened = true;
    }

    // Closes the door by setting the Animator's boolean parameter to false.
    void CloseDoor()
    {
        // Set the Animator's "Open" parameter to false, closing the door.
        doorAnimator.SetBool(boolName, false);

        // Mark the door as closed.
        doorOpened = false;
    }

    // Activates the blue lights and deactivates the red lights when the door is open.
    void ReplaceObjectOpen()
    {
        RedLight1.SetActive(false);
        RedLight2.SetActive(false);

        BlueLight1.SetActive(true);
        BlueLight2.SetActive(true);
    }

    // Activates the red lights and deactivates the blue lights when the door is closed.
    void ReplaceObjectClosed()
    {
        RedLight1.SetActive(true);
        RedLight2.SetActive(true);

        BlueLight1.SetActive(false);
        BlueLight2.SetActive(false);
    }

}
