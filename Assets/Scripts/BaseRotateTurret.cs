using UnityEngine;
using System.Collections;

public class BaseRotateTurret : MonoBehaviour {

    private Transform[] transforms;// to baseclass
    protected Transform Turret; // to baseclass
    protected Vector3 targetPos;
    protected Transform nozzle;
	// Use this for initialization
	protected virtual void Start () {
        bool turretFound = false;
        // to baseclass
        transforms = gameObject.GetComponentsInChildren<Transform>();
        foreach (Transform t in transforms)
        {
            // print("Naam van objecten" + t.gameObject.name);
            if (t.gameObject.name == "Turret")
            {
                Turret = t;
                turretFound = true;
            }
            if (t.gameObject.name == "nozzle")
            {
                nozzle = t;
            }
        }
        if (!turretFound)
        {
            print("no turret was found");
        }
        
	}
	
	// Update is called once per frame
	protected virtual void Update () {
        // to baseclass
        Turret.LookAt(targetPos);
    }
}
