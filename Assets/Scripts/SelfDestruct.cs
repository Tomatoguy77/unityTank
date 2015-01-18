using UnityEngine;
using System.Collections;

public class SelfDestruct : MonoBehaviour {
    public float maxLifeTime;
    private float lifeTime;
    private Light light;
	// Use this for initialization
	void Start () {
        light = GetComponent<Light>();

	}
	
	// Update is called once per frame
	void Update () {

        light.intensity -=  0.1F;
        lifeTime += Time.deltaTime;
        if (lifeTime > maxLifeTime)
        {
            Destroy(this.gameObject);
        }
	}
}
