using UnityEngine;
using System.Collections;

public class Interrupteur : MonoBehaviour {
	
	bool inte = false;
	
	// Use this for initialization
	void Start() {
		inte = false;
	}
	
	// Update is called once per frame
	void Update() {
		if (inte) 
		{
			transform.Translate(Vector3.up * Time.deltaTime);
		}
	}
	void OnTriggerStay(Collider2D other)
	{
		if (other.rigidbody2D)
			inte = true;
	}
	/*if (inte) 
		{
			inte = false;
		}
		else 
		{
			inte = true;
		}*/
}
