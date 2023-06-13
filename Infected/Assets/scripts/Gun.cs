using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class Gun : MonoBehaviour
{
    public RaycastHit hit;
    public Camera cam;
    public GameObject en;
    public float damage = 10f;
    public float delayFactor = 0.01f;
    public bool hasShot;
    public float ammo;
    public bool canShoot;
    public float maxAmmo = 30f;
    public TMP_Text text;

    public float shootdelay, timer;




    void Update()
    {
        timer += Time.deltaTime;
        #region shoot
        if (Input.GetMouseButton(0))
        {
            if (canShoot == true  && timer > shootdelay)
            {
                ammo -= 1;
                timer = 0;

                if (Physics.Raycast(cam.transform.position, transform.forward, out hit, 100))
                {

                    if (hit.transform.tag == "Enemies")
                    {
                        en = hit.transform.gameObject;
                        en.GetComponent<Enemy>().health -= damage;
                        
                    }
                }
            }
        }
        #endregion
            
        if (ammo <= 0)
        {
            canShoot = false;
        }
        else 
            canShoot = true;
        
        if(Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(Reload());
        }

        text.text = ammo.ToString();
    }
            
    

    public IEnumerator Reload()
    {
        yield return new WaitForSeconds(1f);
        ammo = maxAmmo;
    }

     public void Start()
     {
        ammo = maxAmmo;
     }









}
