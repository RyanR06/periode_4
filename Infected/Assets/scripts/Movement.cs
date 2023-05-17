using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float mouseX;

    public float horizontal;
    public float vertical;

    public float rotspeed;
    public float speed;

    public Vector3 v3;
    public Vector3 v3M;

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X");

        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        v3M.x = horizontal;
        v3M.z = vertical;
        v3.y = mouseX;


        transform.Rotate(v3 * Time.deltaTime * rotspeed);
        transform.Translate(v3M * Time.deltaTime * speed);
    }
}
