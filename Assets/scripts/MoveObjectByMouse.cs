using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjectByMouse : MonoBehaviour
{
    private Vector3 MouseOffSet;
    private float MouseZCoord;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseDown() {
        MouseZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        MouseOffSet = gameObject.transform.position - GetMousePosition();
    }

    private Vector3 GetMousePosition()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = MouseZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

    private void OnMouseDrag() {
        transform.position = GetMousePosition() + MouseOffSet;
    }
}
