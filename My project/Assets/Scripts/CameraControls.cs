using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControls : MonoBehaviour
{
 public Transform target;
 public Vector3 posOffset;

 private void LateUpdate()
{

    transform.position = target.position + posOffset;
}
}