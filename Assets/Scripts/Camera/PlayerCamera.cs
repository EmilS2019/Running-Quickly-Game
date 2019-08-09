using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour, IFirstPersonCamera {

    public float MouseSensitivity;
    float xAxisClamp = 0;
    public Transform playerTransform;

    void Start()
    {
        LockCursor();
    }

    public void LockCursor()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        Rotation();
    }

    static float mouseY, mouseX;
    public void Rotation()
    {
        mouseX = Input.GetAxis("Mouse X") * MouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * MouseSensitivity * Time.deltaTime;

        AxisClamp();

        transform.Rotate(-Vector3.right * mouseY);
        playerTransform.Rotate(Vector3.up * mouseX);
    }

    [Range(-90,90)]
    public float MaxClamp;
    [Range(-90,90)]
    public float MinClamp;

    void AxisClamp()
    {
        xAxisClamp += mouseY;
        if (xAxisClamp > MaxClamp)
        {
            xAxisClamp = MaxClamp;
            mouseY = 0f;
        }
        else if (xAxisClamp < MinClamp)
        {
            xAxisClamp = MinClamp;
            mouseY = 0f;
        }
    }
}