using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    Camera viewCam;

    void Start()
    {
        viewCam = Camera.main;
    }

    void Update()
    {
        Vector3 mousePos = viewCam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y));
        transform.LookAt(mousePos + Vector3.up * transform.position.y);
        var mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        transform.rotation = Quaternion.LookRotation(Vector3.forward, (mouseWorldPosition - transform.position).normalized);
    }
}
