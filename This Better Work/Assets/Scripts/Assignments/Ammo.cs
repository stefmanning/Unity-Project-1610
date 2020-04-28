using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public float fireRate = 15f;
    public float impactForce = 30f;


    public int maxAmmo = 10;
    private int currentAmmo;
    public float reloadTime = 1f;


    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;

    private float nextTimeToFire = 0f;

    private void Start()
    {
        currentAmmo = maxAmmo;

    }

    void Update()
    {
        //if (isReloading)
            return;
       // if(currentAmmo <= 0)
        {
            
         
     
        }
        if (Input.GetButton("Fire1") && Time.time >= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            
        }

        IEnumerator Reload()
        {
            //isReloading = true;
            Debug.Log("Reloading...");
            yield return new WaitForSeconds(reloadTime);
        }
    }
}
 