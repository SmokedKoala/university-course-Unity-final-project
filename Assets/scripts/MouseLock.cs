using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLock : MonoBehaviour
{
    public float mouseSencitivity = 100f;

    public Transform Controller;

    float xRotation = 0f;

    // RaycastHit hit;
    // GameObject grabOBJ;
    // public Transform grabPos;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSencitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSencitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        Controller.Rotate(Vector3.up * mouseX);


        // if (Input.GetMouseButtonDown(0))
        // {
        //     Debug.Log(Physics.Raycast(transform.position, transform.forward, out hit, 5));
        //     Debug.Log(hit.transform.GetComponent<Rigidbody>());
        // }
        // if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.forward, out hit, 5) && hit.transform.GetComponent<Rigidbody>())
        // {
        //     grabOBJ = hit.transform.gameObject;
        // }
        // else if (Input.GetMouseButtonUp(0))
        // {
        //     grabOBJ = null;
        // }
        // if (grabOBJ)
        // {
        //     grabOBJ.GetComponent<Rigidbody>().velocity = 10 * (grabPos.position - grabOBJ.transform.position);
        // }
    }
}
