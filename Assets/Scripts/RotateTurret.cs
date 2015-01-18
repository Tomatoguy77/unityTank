using UnityEngine;
using System.Collections;

public class RotateTurret : BaseRotateTurret
{

    public Camera camera;

  

     override protected void Update()
    {
        Vector3 mousePos = Input.mousePosition; //(x,y,x)
        mousePos.z = camera.transform.position.y - Turret.transform.position.y;
        
        Vector3 worldPos = camera.ScreenToWorldPoint(mousePos);
        targetPos = worldPos;
        base.Update();
    }
}