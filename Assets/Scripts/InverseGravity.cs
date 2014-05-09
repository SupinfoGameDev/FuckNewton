using UnityEngine;
using System.Collections;

public class InverseGravity : MonoBehaviour {
	
	// Use this for initialization
	void Update ()
	{
		if(Input.GetButtonDown("Fire2"))
		{
			Physics2D.gravity *= -1;
			Quaternion rotation = transform.localRotation;
			if (Physics2D.gravity.y > 0)
			{
				rotation.x = 180;
				rotation.y = 0;
				rotation.z = 0;
			}
			else
			{
				rotation.x = 0;
				rotation.y = 0;
				rotation.z = 0;
			}
			transform.localRotation = rotation;
		}
	}
}