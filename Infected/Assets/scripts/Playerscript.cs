using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Playerscript : MonoBehaviour
{
    public float health = 100f;
    public int points;
    public TMP_Text text;
    public TMP_Text text2;
    public float maxHealth = 100f;
    void Start()
    {
        points += 500;
        Cursor.lockState = CursorLockMode.Locked;
        health = maxHealth;
        
    }

    
    void Update()
    {
        text.text = points.ToString();
        text2.text = health.ToString();
        if (health < 1)
        {
            SceneManager.LoadScene("GameOverMenu");
            Cursor.lockState = CursorLockMode.None;
        }

        if (health < 100)
        {
            StartCoroutine(Regen());
        
        }
 
    
    }

    public IEnumerator Regen()
    {
        yield return new WaitForSeconds(10);
        health = maxHealth; 
    }
    

    

}
