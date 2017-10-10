using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {

	public float shoothingForce = 10f;
	public Vector3 shoothingDirection;

	public float lifeTime = 3f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody> ().AddForce (shoothingDirection * shoothingForce);		
	}
	
	// Update is called once per frame
	void Update () {
		lifeTime -= Time.deltaTime;
		if (lifeTime <= 0) {
			Destroy (gameObject);
		}
	}
}
