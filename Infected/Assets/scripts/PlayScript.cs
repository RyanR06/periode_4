using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayScript : MonoBehaviour
{
    public void Start_game()
    {
        SceneManager.LoadScene("Infected");
    }
}
