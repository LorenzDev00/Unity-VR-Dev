using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Reference to the GameObject representing the menu.
    public GameObject menu;

    // Reference to the user's Transform, probably representing the main camera or user's head.
    public Transform user;

    // Internal state to track if the menu is currently visible.
    private bool isMenuVisible = false;

    // Update is called once per frame.
    void Update()
    {
        // Check if the 'M' key is pressed down.
        if (Input.GetKeyDown(KeyCode.M))
        {
            // Toggle the visibility state of the menu.
            isMenuVisible = !isMenuVisible;

            // Set the menu's active state based on the visibility toggle.
            menu.SetActive(isMenuVisible);
        }

        // If the menu is visible, position it in front of the user.
        if (isMenuVisible)
        {
            PositionMenu();
        }
    }

    // Positions the menu in front of the user.
    void PositionMenu()
    {
        // Distance in units to place the menu from the user.
        float distanceFromUser = 4.0f;

        // Calculate the new position for the menu based on the user's position and forward direction.
        Vector3 newMenuPosition = user.position + user.forward * distanceFromUser;

        // Set the menu's position.
        menu.transform.position = newMenuPosition;

        // Make the menu face the user.
        menu.transform.LookAt(user);

        // Rotate the menu 180 degrees around the Y-axis to correct its orientation.
        menu.transform.Rotate(0, 180, 0);
    }

}
