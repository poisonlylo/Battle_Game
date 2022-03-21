using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAtqScript : MonoBehaviour{

    private WeaponManager weapon_Manager;
    //weapon bullet
    public float fireRate = 15f;

    private float nextTimeToFire;

    public float damage = 20f;

    void Awake() { //gameObject initialize
        weapon_Manager = GetComponent<WeaponManager>();
    }

    // Update is called once per frame
    void Update()
    {
        WeaponShoot();
    }

     void WeaponShoot(){   // if the gamer use assault riffle
        if (weapon_Manager.GetCurrentSelectedWeapon().fireType == WeaponFireType.MULTIPLE)
        {
            if (Input.GetMouseButton(0) && Time.time > nextTimeToFire)
            {

                nextTimeToFire = Time.time + 1f / fireRate;

                weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();

                //BulletFired();
            }
        }
        else  {
            if (Input.GetMouseButtonDown(0))
            {   
                //handle axe
                if (weapon_Manager.GetCurrentSelectedWeapon().tag == Tags.AXE_TAG)
                {
                    weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();
                }

                //handle shoot
                if (weapon_Manager.GetCurrentSelectedWeapon().bulletType == WeaponBulletType.BULLET){
                    weapon_Manager.GetCurrentSelectedWeapon().ShootAnimation();
                }
            }
        }//else
    }
}
