using UnityEngine;
using System.Collections;

public class InverseGravity : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.E))
		{
			Physics.gravity = -Physics.gravity;
		}
	}
}
