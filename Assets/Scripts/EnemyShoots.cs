﻿using UnityEngine;
using System.Collections;

public class EnemyShoots : MonoBehaviour {
    private float reloadTime;
    public float timeToReload;
    public float shootingRange;
    private Transform turret;
    public GameObject bulletPrefab;
    private Transform nozzle;
	// Use this for initialization
	void Start () {
        reloadTime = 0;

        Transform[] transforms = GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            if (t.gameObject.name == "Turret")
            {
                turret = t;
            }
            if (t.gameObject.name == "nozzle")
            {
                nozzle = t;
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
        reloadTime += Time.deltaTime;
        if (reloadTime >= timeToReload)
        {
            CheckForPlayer();
        }
	}
    private void CheckForPlayer()
    {
        Ray myRay = new Ray();
        myRay.origin = turret.position;
        myRay.direction = turret.forward;

        RaycastHit hitInfo;

        //checken mbv een raycast of de player in zicht is
        if (Physics.Raycast(myRay, out hitInfo, shootingRange))
        {
            print(hitInfo.collider.gameObject.name);
            string hitObjectName = hitInfo.collider.gameObject.name;

            if (hitObjectName == "Tank")
            {
                //zo ja shieten op tank
                Instantiate(bulletPrefab, nozzle.position, nozzle.rotation);

                reloadTime = 0f;
            }
        }



        //zo je schieten en reload time weer op 0 ztten
    }
}
