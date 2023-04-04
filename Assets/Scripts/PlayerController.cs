using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
//Gives ability to use TextMeshPro in scene

public class PlayerController : MonoBehaviour
{

    public float speed;
    // float for speed of charcter movement
    public float upRotation;
    // float for rotation of the camera with the mouse curser for looking up
    public float downRotation;
    // float for rotation of the camera with the mouse curser for looking down
    CharacterController characterControl;
    // helps to use the charcter controller component in code
    public Transform playerCam;
    // the speed of the movement for the camera
    Vector3 vel;
    // signifies the transform for 3D objects
    public float lookSensitivity;
    // to be able to edit the look sensitivity in the inspector
    float xRotation = 0;

    public TMP_Text itemText;
    // Describe what the item text is
    public string lookingAt = "Nothing!";
    // The text that u start when looking at nothing
    public bool hasKey = false;
    // true or false for having the key starts false because start with nothing

    void Start()
    {
        //Cursor.lockState = CursorLockMode.Locked;
        characterControl = GetComponent<CharacterController>();
        // connecting the charcter controller component into the code
        itemText.text = lookingAt;
        // display the text that set for whatever the player is llooking at 
    }


    void Update()
    {
        transform.Rotate(0, Input.GetAxis("Mouse X") * lookSensitivity, 0);
        // move the camera whenever your mouse moves on its x axis
        xRotation -= Input.GetAxis("Mouse Y") * lookSensitivity;
        // move the camera whenever your mouse moves on its y axis
        xRotation = Mathf.Clamp(xRotation, -upRotation, downRotation);
        //
        playerCam.localRotation = Quaternion.Euler(xRotation, 0, 0);
        // keeping the camera in place from rotating continuously

        vel.z = Input.GetAxis("Vertical") * speed;
        //speed of player movement up and down
        vel.x = Input.GetAxis("Horizontal") * speed;
        //speed of player movement left and right 
        vel = transform.TransformDirection(vel);
        //
        characterControl.SimpleMove(vel);
        //
    }
}
