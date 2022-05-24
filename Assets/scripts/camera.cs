using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class camera : MonoBehaviour
{
    RaycastHit hit;
    GameObject grabOBJ;
    public Transform grabPos;

    float xRotation = 0f;

    float sens = 100f;

    void Start()
    {
        GameObject maincamera = GameObject.Find("Main Camera");
        MouseLock mouseLock = maincamera.GetComponent<MouseLock>();
        sens = mouseLock.mouseSencitivity;
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sens * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRotation, 0, 0);
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log(Physics.Raycast(transform.position, transform.forward, out hit, 5));
            Debug.Log(hit.transform.GetComponent<Rigidbody>());
        }
        if (Input.GetMouseButtonDown(0) && Physics.Raycast(transform.position, transform.forward, out hit, 5) && hit.transform.GetComponent<Rigidbody>())
        {
            grabOBJ = hit.transform.gameObject;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            grabOBJ = null;
        }
        if (grabOBJ)
        {
            grabOBJ.GetComponent<Rigidbody>().velocity = 10 * (grabPos.position - grabOBJ.transform.position);
        }
    }
}