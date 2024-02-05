using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform follow;
    public Vector3 offset; // 얼만큼 거리를 두고 따라가야 하는지, 격차

	private void LateUpdate() // 보통은 그냥 Update 말고 LateUpdate에서 카메라 설정해주는 것이 보통
	{
		transform.position = follow.position + offset;
		transform.LookAt(follow.position);
	}

}
