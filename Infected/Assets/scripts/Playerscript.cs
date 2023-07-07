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
        if (health < 1)
        {
            DestroyImmediate(this.gameObject);
        }

        if (health < 100)
        {
            StartCoroutine(Regen());
        
        }
        if (health >= 100) 
        {
            health = 100;
        }
    
    }

    public IEnumerator Regen()
    {
        yield return new WaitForSeconds(3);
        health += 10f;
    }
    

    

}
