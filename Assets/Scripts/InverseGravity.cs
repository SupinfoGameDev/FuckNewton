using UnityEngine;
using System.Collections;

public class InverseGravity : MonoBehaviour {

	int speed = 10;
	// Use this for initialization
	void Start () {
	}
	// Update is called once per frame
	void Update(){
		if(Input.GetButtonDown("Fire1"))
		{
			if(speed > 0)
			{
				Physics.gravity = new Vector3(0, speed, 0);
				speed = -10;
				moveAll();
			}
			else
			{   
				Physics.gravity = new Vector3(0, speed, 0);
				speed = 10;
				moveAll();
			}
		}
	}
	
	void moveAll()
	{    
		var objectsToEffect = GameObject.FindGameObjectsWithTag ("ObjectToEffect");
		foreach (var obj in objectsToEffect) {
			obj.Physics.gravity = Vector3(0, speed, 0);
		}
	}
}