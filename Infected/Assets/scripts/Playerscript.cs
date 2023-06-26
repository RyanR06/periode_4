using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Playerscript : MonoBehaviour
{
    public float health = 100f;
    public int points;
    public TMP_Text text;
    void Start()
    {
        points += 500;
        Cursor.lockState = CursorLockMode.Locked;
    }

    
    void Update()
    {
        text.text = points.ToString();
       if(health <= 0)
        {
            Destroy(gameObject);
        } 
    }

    

    

}
