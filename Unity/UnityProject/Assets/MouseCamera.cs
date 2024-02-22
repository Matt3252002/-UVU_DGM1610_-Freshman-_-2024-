using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseCamera : MonoBehaviour
{

    public float mouseSensitivity = 100f; // variable for mouse sensitivity 

    public Transform playerBody;

    float xRotation = 0f;


    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // locks cursor in place
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime; // controls the x axis
        float MouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime; // controls the y axis

        xRotation -= MouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f); // rotation on the transform
        playerBody.Rotate(Vector3.up * mouseX); // connects to player object
    }
}
