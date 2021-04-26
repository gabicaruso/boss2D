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
}
