using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public bool check;
    // Update is called once per frame
    void Update()
    {
        if( Input.anyKey)
        {
            check = true;
            SceneManager.LoadScene("Main Menu");
        }
    }
}
