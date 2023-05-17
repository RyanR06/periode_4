using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CMove : MonoBehaviour
{
    public float mouseY;
    public float rotspeed;
    public Vector3 v3;
    public Transform t;

    void Update()
    {
        mouseY = Input.GetAxis("Mouse Y");

        v3.x = -mouseY;

        t.Rotate(v3 * Time.deltaTime * rotspeed);
    }
}
