using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
   public Transform target;
   public float lastPos;
   public float now;

   Vector3 _lastPosition;
   Vector3 delta;

    // void Start()
    // {
    //     // set initial value for lastPosition
    //     _lastPosition = transform.position;
	// 	Debug.Log("start:" + _lastPosition.y);
    // }

	// void Update(){

	// 	// get current position
    //     delta = transform.position - _lastPosition;
	// 	Debug.Log("delta:" + delta.y);

    //     // do anything you need to with the positions
    //    // DoStuff(currentPosition, _lastPosition);

    //     // set last to current so the next frame of Update() is ready
    //     _lastPosition = transform.position;

	// 	// lastPos = transform.position.y;
	// 	// now = transform.position.y;
	// 	Debug.Log("last:" + _lastPosition.y);


	// }

	// void LateUpdate () {

	// 	// get current position
    //     currentPosition = transform.position;
	// 	Debug.Log("current:" + currentPosition.y);

    //     // do anything you need to with the positions
    //    // DoStuff(currentPosition, _lastPosition);

    //     // set last to current so the next frame of Update() is ready
    //     _lastPosition = transform.position;

	// 	// lastPos = transform.position.y;
	// 	// now = transform.position.y;
	// 	Debug.Log("last:" + _lastPosition.y);
	// 	Debug.Log("sub:" +(_lastPosition.y - currentPosition.y));
	// 	// if (target.position.y > transform.position.y)
	// 	// {
	// 	// 	Vector3 newPos = new Vector3(transform.position.x, target.position.y, transform.position.z);
	// 	// 	transform.position = newPos;
	// 	// }
	// }
}
