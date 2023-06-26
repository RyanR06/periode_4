using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public float health = 100f;
    public int points;
    void Start()
    {
        points += 500;
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
       if(health <= 0)
        {
            Destroy(gameObject);
        } 
    }

    

    

}
