using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ButtonPushOpenDoor : MonoBehaviour
{
    // Reference to the Animator component that controls the door's animations.
    public Animator animator;

    // The name of the boolean parameter in the Animator that controls the open/close state.
    public string boolName = "Open";

    // Time in seconds after which the door should automatically close.
    public float autoCloseDelay = 5f;

    // Start is called before the first frame update.
    void Start()
    {
        // Attach a listener to the selectEntered event of the XRSimpleInteractable component.
        // This listener will call the ToggleDoorOpen method whenever the event is triggered.
        GetComponent<XRSimpleInteractable>().selectEntered.AddListener(x => ToggleDoorOpen());
    }

    // Toggles the door's open state.
    public void ToggleDoorOpen()
    {
        // Get the current value of the boolean parameter from the Animator.
        bool isOpen = animator.GetBool(boolName);

        // Set the boolean parameter to the opposite value, toggling the door's state.
        animator.SetBool(boolName, !isOpen);

        // Schedule the CloseDoor method to be called after the specified delay.
        Invoke("CloseDoor", autoCloseDelay);
    }

    // Closes the door by setting the Animator's boolean parameter to false.
    void CloseDoor()
    {
        animator.SetBool(boolName, false);
    }

}
