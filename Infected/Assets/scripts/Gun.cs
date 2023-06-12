using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public RaycastHit hit;
    public Camera cam;
    public Enemy en;
    public float damage = 10f;
    public float delayFactor = 0.01f;




    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            if (Physics.Raycast(cam.transform.position, transform.forward, out hit, 100))
            {
                if (hit.transform.tag == "Enemies")
                {
                    en.health -= damage * delayFactor * Time.deltaTime;
                }
            }
        }
    }
}
