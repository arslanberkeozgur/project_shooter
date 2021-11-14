using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAimPC : MonoBehaviour
{
    // Get the middle position of the screen and convert to (x,z).
    Vector3 middlePoint = new Vector3(Screen.width / 2f, 0, Screen.height / 2f);

    // Update is called once per frame
    void Update()
    {
        // Convert the mouse position to (x,z)
        Vector3 newMouse = new Vector3(Input.mousePosition.x, 0, Input.mousePosition.y);
        // Get the relative position of the mouse to the player.
        Vector3 relativeMouse = newMouse - middlePoint;
        // Convert this relative position into real world position.
        Vector3 pointToLook = transform.position + relativeMouse;
        // Look at the real world position.
        transform.LookAt(pointToLook);
    }
}
