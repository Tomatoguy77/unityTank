using UnityEngine;
using System.Collections;

public class MoveTank : MonoBehaviour {
	public float rotationSpeed = 8.5f;
	public float moveSpeed = 0.5f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.UpArrow)) {
			//0,0,1 moves on z axis
			transform.Translate(Vector3.forward * moveSpeed);

		}
		if (Input.GetKey (KeyCode.DownArrow)) {

			transform.Translate(-Vector3.forward *  moveSpeed);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			
			transform.Rotate(-Vector3.up * rotationSpeed);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			
			transform.Rotate(Vector3.up * rotationSpeed);
		}
	}
}
