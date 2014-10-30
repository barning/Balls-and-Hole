using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

	public float playerRotationSpeed = 5.0f;
	public float playerSpeed = 5.0f;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(Vector3.right * Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime);
		transform.Rotate (Vector3.up * Input.GetAxis ("Horizontal") * playerRotationSpeed * Time.deltaTime);
	}
}
