using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitScript : MonoBehaviour
{
    public void button_exit()
    {

        Application.Quit();
        Debug.Log("exit");
    }
}
