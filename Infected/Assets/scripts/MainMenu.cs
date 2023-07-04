using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public GameObject mainMenu;
    public GameObject Settings;

    public ResolutionRes[] res;
    public void OnClickPlay()
    {

    }
    public void ResSettings()
    {

    }

    [System.Serializable]
    public class ResolutionRes
    {
        public int width;
        public int height;
    }
    




}
